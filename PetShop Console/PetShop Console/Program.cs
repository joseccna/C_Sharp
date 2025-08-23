using System;
using System.Collections.Generic;
using System.Linq;

namespace PetShop_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listaAnimais = new List<Animal>();

            Console.WriteLine("=== Bem-vindo ao PetShop ===\n");

            bool continuar = true;
            while (continuar)
            {
                // Escolher tipo de animal
                Animal animal;
                while (true)
                {
                    Console.WriteLine("Escolha o tipo de animal para cadastrar:");
                    Console.WriteLine("1 - Cachorro");
                    Console.WriteLine("2 - Gato");
                    Console.Write("Digite sua opção (1 ou 2): ");
                    string opcao = Console.ReadLine()??"";

                    if (opcao == "1")
                    {
                        animal = new Cachorro();
                        break;
                    }
                    else if (opcao == "2")
                    {
                        animal = new Gato();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Digite 1 ou 2.\n");
                    }
                }

                // Preencher dados do animal
                PreencherAnimal(animal);

                // Adiciona na lista
                listaAnimais.Add(animal);

                // Pergunta se quer cadastrar outro
                Console.Write("Deseja cadastrar outro animal? (S/N): ");
                string resposta = Console.ReadLine()?.ToUpper() ?? "N";
                if (resposta != "S")
                    continuar = false;

                Console.WriteLine();
            }

            // Chamar animais para atendimento
            Console.WriteLine("=== Chamando animais para atendimento ===\n");
            foreach (var a in listaAnimais)
            {
                Console.WriteLine($"Chamando {a.NomeAnimal} ({a.EspecieAnimal}) para atendimento!");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static void PreencherAnimal(Animal animal)
        {
            dynamic dynAnimal = animal; // usamos dynamic para acessar as propriedades específicas

            // Nome
            while (true)
            {
                Console.Write("Digite o nome do animal: ");
                string nome = Console.ReadLine() ?? "";
                if (!string.IsNullOrWhiteSpace(nome) && nome.Length >= 3 && nome.All(char.IsLetter))
                {
                    dynAnimal.NomeAnimal = nome;
                    break;
                }
                Console.WriteLine("❌ Nome inválido. Use apenas letras e pelo menos 3 caracteres.\n");
            }

            // Espécie
            while (true)
            {
                Console.Write("Digite a espécie do animal: ");
                string especie = Console.ReadLine() ?? "";
                if (!string.IsNullOrWhiteSpace(especie) && especie.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    dynAnimal.EspecieAnimal = especie;
                    break;
                }
                Console.WriteLine("❌ Espécie inválida. Use apenas letras e espaços.\n");
            }

            // Idade
            while (true)
            {
                Console.Write("Digite a idade do animal: ");
                if (int.TryParse(Console.ReadLine(), out int idade) && idade >= 0)
                {
                    dynAnimal.IdadeAnimal = idade;
                    break;
                }
                Console.WriteLine("❌ Idade inválida. Digite um número maior ou igual a 0.\n");
            }

            Console.WriteLine();
        }
    }
}
