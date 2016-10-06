using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSum
{
    public class ArquivoDTO
    {

        public int ID { get; set; }

        public string Nome { get; set; }

        public string Caminho { get; set; }

        public string CheckSum { get; set; }

        public string Extensao { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataPesquisa { get; set; }

        public Int64 Tamanho { get; set; }

        public string Dono { get; set; }

        public string Grupo { get; set; }


        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            ArquivoDTO p = obj as ArquivoDTO;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (CheckSum == p.CheckSum);
        }

        public bool Equals(ArquivoDTO p)
        {
            // If parameter is null return false:
            if ((object)p == null)
            {
                return false;
            }

            return (CheckSum == p.CheckSum);

        }

        public override int GetHashCode()
        {
            return ID ^ 10 ;
        }

    }
}
