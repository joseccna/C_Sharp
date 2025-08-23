using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Console
{
    public class Animal
    {
        // Campos protegidos
        protected string Nome = "";
        protected int Idade;
        protected string Especie = "";


        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine($"Espécie: {Especie}");
        }


    }
}
