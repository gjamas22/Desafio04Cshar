using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04Cshar
{
    class Loja
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }
        
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames = videoGames;

        }

        public Loja()
        {
        }

        public void listaLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros no estoque");
            }
            else
            {
                foreach (Livro index in Livros)
                {
                    Console.WriteLine("Titulo" + index.Nome + " , preço: " + index.Preço + " , quantidade " + index.Qntd
                        + " em estoque");
                }
                
            }
            Console.WriteLine("=====================================================================================================");
        }

        public void listaVideoGames()
        {
            if (VideoGames.Count == 0)
            {
                Console.WriteLine("A loja não tem video-games no seu estoque");
            }
            else
            {
                foreach(VideoGame index in VideoGames)
                {
                    Console.WriteLine("Video game: " + index.Modelo + " , preço :" + index.Preço +
                        ", quantidade " + index.Qntd + " em estoque.");
                }
            }
            Console.WriteLine("=====================================================================================================");
        }

        public double calcularPatrimonio()
        {   
           
            double result = 0.00;
            foreach (Livro index in Livros)
            {
                result = result + (index.Preço * index.Qntd);
            }foreach (VideoGame index in VideoGames)
            {
                result = result + (index.Preço * index.Qntd);
            }
            Console.WriteLine("O patrimonio da loja " + Nome + " é de " + result);
            return result;
        
        }
        


    }
}
