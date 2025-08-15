using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_final_alunos
{
    public class Aluno
    {

        public string nome = "";
        public double nota1;
        public double nota2;

        public void LerDados()
        {
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine() ??"";
            Console.Write("Digite a nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
        }

        public double CalcularMedia()
        {
            return (nota1 + nota2) / 2;
        }   
        public void ExibirResultado()
        {
            double media = CalcularMedia();
            Console.WriteLine($"Aluno: {nome}");
            Console.WriteLine($"Nota 1: {nota1}");
            Console.WriteLine($"Nota 2: {nota2}");
            Console.WriteLine($"Média: {media}");
            if (media >= 7)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Situação: Recuperação");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }
        }   
















    }





}
