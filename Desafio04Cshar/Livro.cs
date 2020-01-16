using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04Cshar
{
    class Livro : Produto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QntdPag { get; set; }

        public Livro(string nome, double preço, int qntd, string autor, string tema, int qntdPag) : base(nome,preço,qntd)
        {
            Autor = autor;
            Tema = tema;
            QntdPag = qntdPag;
        }

        public Livro()
        {
        }

        public double CalculaImposto()
        {
            double imp = 0;
            if (Tema == "educativo")
            {
                Console.WriteLine("Livro educativo não tem imposto: " + Nome + ".");
            }
            else
            {
                imp = Preço * 0.10;
                Console.WriteLine("R$ " + imp + " de imposto sobre o livro " + Nome + ".");
            }
            return imp;
        }
    }
}
