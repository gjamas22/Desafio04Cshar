using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04Cshar
{
    class VideoGame : Produto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        public VideoGame(string nome, double preço, int qntd,string marca, string modelo, bool isUsado) : base (nome,preço,qntd)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public VideoGame()
        {
        }

        public double CalculaImposto()
        {
            double imp = 0;
            if (IsUsado == true)
            {
                imp = Preço * 0.10;
                Console.WriteLine("Imposto " + Nome + " , " + imp + ".");
            }
            else
            {
                imp = Preço * 0.45;
                Console.WriteLine("Imposto " + Nome + " , " + imp + ".");
                Console.WriteLine("=====================================================================================================");
            }
            return 0.0;
        }
    }
}
