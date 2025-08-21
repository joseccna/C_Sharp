// Projeto empresa Polimorfismo e Herança,  dia 20-08-2025

using System;
//using PolimorfismoHeranca;

namespace PolimorfismoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            
            vendedor.Nome = "Jão Silva";
            vendedor.Idade = 30;
            vendedor.ID = 123;

            Gerente gerente = new Gerente();

            gerente.Nome = "Maria Oliveira";
            gerente.Idade = 40;
            gerente.Salario = 2500;

            Console.WriteLine($"Vendedor: {vendedor.Nome}, Idade: {vendedor.Idade}, Comissão: {vendedor.Comissao()}, ID: {vendedor.ID}");
            Console.WriteLine($"Gerente: {gerente.Nome}, Idade: {gerente.Idade}, Comissão: {gerente.Comissao()}, Salario: {gerente.Salario} ");

        }
    }
}
