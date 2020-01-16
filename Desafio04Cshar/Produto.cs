using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04Cshar
{
    abstract class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Qntd { get; set; }

        protected Produto(string nome, double preço, int qntd)
        {
            Nome = nome;
            Preço = preço;
            Qntd = qntd;
        }

        protected Produto()
        {
        }
    }
}
