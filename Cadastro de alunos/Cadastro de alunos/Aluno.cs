using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_alunos
{
    public class Aluno
    {
        public string nome = "";
        public string telefone = "";
        public double nota1 = 0.0;
        public double nota2 = 0.0;

        public void LerDados()
        {
            Console.WriteLine("Digite o nome do aluno:");
            nome = Console.ReadLine() ?? "";
            Console.WriteLine("Digite o telefone do aluno:");
            telefone = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a nota 1 do aluno:");
            nota1 = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Digite a nota 2 do aluno:");
            nota2 = double.Parse(Console.ReadLine() ?? "0");
        }

        public double CalcularMedida()
        {
            return (nota1 + nota2) / 2;
        }

        public string obtersituacao()
        {
            double media = CalcularMedida();
            if (media >= 7)
            {
                return "Aprovado";
            }
            else if (media >= 5)
            {
                return "Recuperação";
            }
            else
            {
                return "Reprovado";
            }
        }
        public void ImprimirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"Nota 1: {nota1}");
            Console.WriteLine($"Nota 2: {nota2}");
            Console.WriteLine($"Média: {CalcularMedida()}");
            Console.WriteLine($"Situação: {obtersituacao()}");


        }


    }
}




