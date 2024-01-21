using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.Id = 1;
            produto.Titulo = "Mouse Gamer";
            produto.Preco = 197.23f;

            Console.WriteLine(produto.Id);
            Console.WriteLine(produto.Titulo);
            Console.WriteLine(produto.Preco);

            Produto1 produto1 = new Produto1(2, "Teclado Gamer", 700.84f);

            Console.WriteLine(produto1.Id);
            Console.WriteLine(produto1.Titulo);
            Console.WriteLine(produto1.Preco);
        }
    }

    struct Produto1
    {
        public int Id;
        public string Titulo;
        public float Preco;
        public Produto1(int id, string titulo, float preco)
        {
            Id = id;
            Titulo = titulo;
            Preco = preco;
        }
    }

    struct Produto
    {
        public int Id;
        public float Preco;
        public string Titulo;

        public float PrecoEmDolar(float dolar)
        {
            return Preco * dolar;
        }
    }
}
