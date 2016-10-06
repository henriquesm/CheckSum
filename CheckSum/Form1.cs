using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace CheckSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int arqcadastrados = 0;
        int erros = 0;
        DataBase _dataBase = new DataBase();

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            string dados = string.Empty;
            string[] padroes = new string[2];
            DirectoryInfo dir = null;
            padroes[0] = "*.txt";
            padroes[1] = "*.pdf";

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);

                 btnArquivo.Visible = false;

                 ProcurarDiretorio(dir, padroes);

                 lblNumArqCadastrados.Text = arqcadastrados.ToString();
                 lblNumErros.Text = erros.ToString();
            }


        }

        private string GetChecksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
               // return BitConverter.ToString(checksum);
            }

        }

        private void ProcurarDiretorio(DirectoryInfo dir_info, string[] padroes)
        {
            try
            {
                // Procura o diretorio
                foreach (string padrao in padroes)
                {
                    // Verifica o padrão
                    //foreach (FileInfo Arq_info in dir_info.GetFiles(padrao))
                    foreach (FileInfo Arq_info in dir_info.GetFiles(padrao))
                    {
                        // Processa o arquivo
                        ProcessaArquivo( Arq_info);
                    }
                }
                // Procura nos subdiretorios
                foreach (DirectoryInfo subdir_info in dir_info.GetDirectories())
                {
                    ProcurarDiretorio( subdir_info, padroes);
                }
            }
            catch (Exception ex)
            {
                erros++;
                Debug.WriteLine("Erro = " + ex.Message, "ERROR");
            }
        }


        private void ProcessaArquivo(FileInfo arq_info)
        {
            try
            {
                ArquivoDTO dto = new ArquivoDTO();


                dto.Nome = arq_info.Name;
                dto.Caminho = arq_info.FullName;
                dto.Extensao = arq_info.Extension;
                dto.DataCriacao = arq_info.CreationTime;
                dto.Tamanho = arq_info.Length;
                dto.CheckSum = GetChecksum(arq_info.FullName);
                dto.Dono = System.IO.File.GetAccessControl(arq_info.FullName).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
                dto.Grupo = System.IO.File.GetAccessControl(arq_info.FullName).GetGroup(typeof(System.Security.Principal.NTAccount)).ToString();

                _dataBase.InserirArquivo(dto);

                arqcadastrados++;
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao processar o arquivo " + arq_info.FullName + "\n" + ex.Message);
                erros++;
                Debug.WriteLine("Erro ao processar o arquivo " + arq_info.FullName + "\n" + ex.Message, "ERROR");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            List<ArquivoDTO> lista = new List<ArquivoDTO>();
            DataBase database = new DataBase();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              lista = database.ListarArquivos(GetChecksum(openFileDialog1.FileName));
            }

            gridArquivos.DataSource = lista;
        }

        private void gridArquivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string filename = gridArquivos[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (e.ColumnIndex == 2 && File.Exists(filename))
            {
                Process.Start(filename);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbl1Arquivo.Text = openFileDialog2.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbl2Arquivo.Text = openFileDialog3.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool iguais = false;

            if (!string.IsNullOrEmpty(lbl1Arquivo.Text) && !string.IsNullOrEmpty(lbl2Arquivo.Text))
            {
                if (GetChecksum(lbl1Arquivo.Text) == GetChecksum(lbl2Arquivo.Text))
                {
                    MessageBox.Show("Arquivos Iguais.");
                }
                else
                {
                    MessageBox.Show("Arquivos diferentes.");
                }
            }
            else
                MessageBox.Show("Favor selecionar os 2 arquivos para a comparação.");




        }
    }
}
