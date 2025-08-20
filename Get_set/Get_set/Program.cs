// Aula de get set

using System;
using Get_set;

namespace Get_set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetSet getSet = new GetSet();
            getSet.Nome = "João";
            getSet.Idade = 30;
            Console.WriteLine($"Nome: {getSet.Nome}, Idade: {getSet.Idade}");
        }
    }
}
