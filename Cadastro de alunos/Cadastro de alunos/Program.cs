using System;                         // Importa a biblioteca base do .NET (Console, tipos primitivos, etc.)
using Cadastro_de_alunos;             // Importa o namespace onde (presumivelmente) está definida a classe 'Aluno'

class Program                         // Declara a classe principal do programa (ponto de entrada)
{
    static void Main(string[] args)   // Método principal: onde a execução do programa começa
    {
        Aluno[] alunos = new Aluno[3];    // Cria um array de 3 posições para armazenar referências de 'Aluno' (todas começam como null)

        for (int i = 0; i < alunos.Length; i++) // Loop que vai de i=0 até i=2 (3 iterações, uma por posição do array)
        {
            alunos[i] = new Aluno();     // Instancia um novo objeto Aluno e coloca na posição i do array
            alunos[i].LerDados();        // Chama o método 'LerDados' do Aluno para preencher seus atributos (por ex., via Console.ReadLine)
        }

        Console.Clear();                 // Limpa a tela do console (apaga o que foi digitado/mostrado até aqui)

        for (int i = 0; i < alunos.Length; i++) // Segundo loop para percorrer de novo os 3 alunos
        {
            alunos[i].ImprimirDados();   // Imprime no console os dados do aluno da posição i (método da classe Aluno)
            Console.WriteLine();         // Escreve uma linha em branco para separar visualmente um aluno do outro
        }

        Console.WriteLine("Pressione qualquer tecla para sair..."); // Mensagem final para o usuário
        Console.ReadKey();                // Aguarda o pressionamento de qualquer tecla antes de encerrar
    }
}
