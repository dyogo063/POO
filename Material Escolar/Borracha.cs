using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    internal class Borracha
    {
        private string cor;
        private string marca;
        private bool tamanho;
        public bool apagar;
        public int percentualBorracha;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string Marca
        {
            get { return marca; }  
            set { marca = value; }
        }
        public bool Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public Borracha()
        {
            percentualBorracha = 100;
        }
        public void Apagar()
        {
            apagar = true;
        }
        public void Apagar(string text)
        {
            if(apagar)
            {
                Console.WriteLine("vapo!");
            }

        }
        public void GastarBorracha(int _percentual)
        {
            percentualBorracha -= _percentual;
            if (percentualBorracha > 0)
                percentualBorracha = 0;

        }
         
        }

    }
}
