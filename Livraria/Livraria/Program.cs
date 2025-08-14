using System;
using Livraria;

class Program
{
    static void Main(string[] args)
    {
        Livro l1 = new Livro();  // Usando inicializador de objeto

        l1.Titulo = "O Senhor dos Anéis";
        l1.Autor = "J.R.R. Tolkien";
        l1.Ano = 1954;

        //Criando um segundo livro usando inicializador de objeto 
        //de forma mais concisa

        Livro l2 = new Livro
        {
            Titulo = "1984",
            Autor = "George Orwell",
            Ano = 1949
        };

        //Console.WriteLine($"Título: {l1.Titulo} - Título: {l2.Titulo}");
        //Console.WriteLine($"Autor: {l1.Autor} - Autor: {l2.Autor}");
        //Console.WriteLine($"Ano: {l1.Ano} - Ano: {l2.Ano}");

        l1.Atualizacao(2023); // Atualizando o ano do primeiro livro

        l1.ExibirDetalhes();
        l2.ExibirDetalhes();

        Console.WriteLine($"Idade do livro '{l2.Titulo}': {l2.CalcularIdade()} anos");
    }
}