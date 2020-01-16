using System;
using System.Collections.Generic;

namespace Desafio04Cshar
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40.00, 50, "J.K.Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60.00, 30, "J.R.R.Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20.00, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800.00, 100, "Sony", "Slin", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000.00, 7, "Sony", "Slin", true);
            VideoGame xbox = new VideoGame("XBOX", 1500.00, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> videoGames = new List<VideoGame>();
            videoGames.Add(ps4);
            videoGames.Add(ps4Usado);
            videoGames.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, videoGames);

            l2.CalculaImposto();
            l3.CalculaImposto();

            ps4Usado.CalculaImposto();
            ps4.CalculaImposto();

            Console.WriteLine("A loja americanas possui esses livros para venda :");
            americanas.listaLivros();
            Console.WriteLine("A loja americanas possui esses video games para venda :");
            americanas.listaVideoGames();
            americanas.calcularPatrimonio();
        }
	}
}
