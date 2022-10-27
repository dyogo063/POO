using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Apontador
    {
        private string cor;
        private string marca;
        private string material;
        private bool lamina;

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
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public bool Lamina
        {
            get { return lamina; }
            set { lamina = value; }
        }
        public Apontador(string _cor, string _marca, string _material)
        {
            Cor = _cor;
            Marca = _marca;
            Material = _material;



        }
        public void Apontar(bool _lamina)
        {
            lamina = true;
        }
        public void Apontar(string _text)
        {
            if (!Lamina)
            {
                Console.WriteLine("Impossivel de ser ultilizado sem lamina");
                return;
            }

        }
        public void Exibir()
        {
            Console.WriteLine("Cor: "+ Cor);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Material: "+ Material);
        }

    }
}
