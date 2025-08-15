using System;
using desafio_final_alunos;

class Program
{
    static void Main(string[] args)
    {
        Aluno[] alunos = new Aluno[3];

        for (int i = 0; (i) < alunos.Length; (i)++)
        {
            alunos[i] = new Aluno();
            alunos[i].LerDados();
            
        }
        Console.Clear();
        for (int i = 0; i < alunos.Length; i++)
        {
            alunos[i].ExibirResultado();
            Console.WriteLine(); // Linha em branco para separar os resultados
        }

        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
