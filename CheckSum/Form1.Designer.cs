namespace CheckSum
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumErros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumArqCadastrados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridArquivos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caminho = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.lbl1Arquivo = new System.Windows.Forms.Label();
            this.lbl2Arquivo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArquivos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnArquivo
            // 
            this.btnArquivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArquivo.Location = new System.Drawing.Point(0, 0);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(177, 100);
            this.btnArquivo.TabIndex = 2;
            this.btnArquivo.Text = "Mapiar Arquivos";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnArquivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNumErros);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNumArqCadastrados);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(177, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 100);
            this.panel2.TabIndex = 3;
            // 
            // lblNumErros
            // 
            this.lblNumErros.AutoSize = true;
            this.lblNumErros.Location = new System.Drawing.Point(59, 37);
            this.lblNumErros.Name = "lblNumErros";
            this.lblNumErros.Size = new System.Drawing.Size(0, 13);
            this.lblNumErros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Erros: ";
            // 
            // lblNumArqCadastrados
            // 
            this.lblNumArqCadastrados.AutoSize = true;
            this.lblNumArqCadastrados.Location = new System.Drawing.Point(135, 11);
            this.lblNumArqCadastrados.Name = "lblNumArqCadastrados";
            this.lblNumArqCadastrados.Size = new System.Drawing.Size(0, 13);
            this.lblNumArqCadastrados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivos Cadastrados: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridArquivos);
            this.panel3.Controls.Add(this.btnVerificar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 482);
            this.panel3.TabIndex = 4;
            // 
            // gridArquivos
            // 
            this.gridArquivos.AllowUserToAddRows = false;
            this.gridArquivos.AllowUserToDeleteRows = false;
            this.gridArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CheckSum,
            this.Extensao,
            this.DataCriacao,
            this.tamanho,
            this.DataPesquisa,
            this.Caminho});
            this.gridArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridArquivos.Location = new System.Drawing.Point(0, 32);
            this.gridArquivos.Name = "gridArquivos";
            this.gridArquivos.ReadOnly = true;
            this.gridArquivos.Size = new System.Drawing.Size(563, 450);
            this.gridArquivos.TabIndex = 1;
            this.gridArquivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArquivos_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CheckSum
            // 
            this.CheckSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckSum.DataPropertyName = "CheckSum";
            this.CheckSum.HeaderText = "CheckSum";
            this.CheckSum.Name = "CheckSum";
            this.CheckSum.ReadOnly = true;
            // 
            // Extensao
            // 
            this.Extensao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Extensao.DataPropertyName = "Extensao";
            this.Extensao.HeaderText = "Extensao";
            this.Extensao.Name = "Extensao";
            this.Extensao.ReadOnly = true;
            // 
            // DataCriacao
            // 
            this.DataCriacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataCriacao.DataPropertyName = "DataCriacao";
            this.DataCriacao.HeaderText = "DataCriacao";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            // 
            // tamanho
            // 
            this.tamanho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tamanho.DataPropertyName = "tamanho";
            this.tamanho.HeaderText = "tamanho";
            this.tamanho.Name = "tamanho";
            this.tamanho.ReadOnly = true;
            // 
            // DataPesquisa
            // 
            this.DataPesquisa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataPesquisa.DataPropertyName = "DataPesquisa";
            this.DataPesquisa.HeaderText = "DataPesquisa";
            this.DataPesquisa.Name = "DataPesquisa";
            this.DataPesquisa.ReadOnly = true;
            // 
            // Caminho
            // 
            this.Caminho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Caminho.DataPropertyName = "Caminho";
            this.Caminho.HeaderText = "Caminho";
            this.Caminho.Name = "Caminho";
            this.Caminho.ReadOnly = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerificar.Location = new System.Drawing.Point(0, 0);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(563, 32);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar Arquivo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.lbl2Arquivo);
            this.panel4.Controls.Add(this.lbl1Arquivo);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 461);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 121);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Compara Arquivos Diferentes:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1º Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2º Arquivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // lbl1Arquivo
            // 
            this.lbl1Arquivo.AutoSize = true;
            this.lbl1Arquivo.Location = new System.Drawing.Point(97, 53);
            this.lbl1Arquivo.Name = "lbl1Arquivo";
            this.lbl1Arquivo.Size = new System.Drawing.Size(0, 13);
            this.lbl1Arquivo.TabIndex = 3;
            // 
            // lbl2Arquivo
            // 
            this.lbl2Arquivo.AutoSize = true;
            this.lbl2Arquivo.Location = new System.Drawing.Point(97, 82);
            this.lbl2Arquivo.Name = "lbl2Arquivo";
            this.lbl2Arquivo.Size = new System.Drawing.Size(0, 13);
            this.lbl2Arquivo.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Comparar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 582);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArquivos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumErros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumArqCadastrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.DataGridView gridArquivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPesquisa;
        private System.Windows.Forms.DataGridViewLinkColumn Caminho;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl2Arquivo;
        private System.Windows.Forms.Label lbl1Arquivo;
    }
}

