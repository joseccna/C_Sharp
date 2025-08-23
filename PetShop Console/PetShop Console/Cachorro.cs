using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Console
{
    internal class Cachorro : Animal
    {

        public string NomeAnimal
        {

            get { return Nome; }
            set { Nome = value; }
        }
        public int IdadeAnimal
        {
            get { return Idade; }
            set { Idade = value; }
        }

        public string EspecieAnimal
        {
            get { return Especie; }
            set { Especie = value; }
        }


        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine($"Espécie: {Especie}");
            Console.WriteLine("Ruff! Ruff!"); // Som do cachorro
        }


    }
}