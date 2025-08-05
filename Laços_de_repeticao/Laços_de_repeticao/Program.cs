
// loço de repetição
// Laço de repetição: For
// laçor de repetição: while
// laço de repetição: do while

// laço de repetição sera efetuado enquanto a condição for verdadeira
//while (condição) { 


//}

//////////////////////////

// laço de repetição do while será efetuado pelo menos uma vez,
// mesmo que a condição seja falsa

//do
//{
// código a ser executado
// enquanto a condição for verdadeira
// código a ser executado pelo menos uma vez
//    Console.WriteLine("Executando o laço de repetição do while");
//} while (condição);

/////////////////////
// laço de repetição for
// A sintaxe do laço de repetição for é a seguinte:
// for (inicialização; condição; incremento/decremento) { };
//
// for (int i = 0; i < 10; i++)
// 

using System.Runtime.Serialization;

int idade = 0; // Variável para armazenar a idade
int contador = 1; // Contador para o laço
int controle = 0; // Variável de controle para o laço
int media = 0; // Variável para armazenar a média das idades
Console.WriteLine("Digite idade e quando quiser sair digite um numero negativo!");
Console.WriteLine("Digite uma idade: ");
controle = Convert.ToInt32(Console.ReadLine()); // Lê a idade inicial
idade = controle; // Atribui a idade inicial à variável idade
while (controle > 0)
{
    Console.WriteLine("Digite uma nova idade: ");
    controle = Convert.ToInt32(Console.ReadLine());
    if (controle < 0) // Verifica se o número é negativo
    {
        break; // Sai do laço se o número for negativo
    }
    // Se o número for positivo, continua o laço
    idade += controle; // Soma a nova idade à variável idade
    contador++; // Incrementa o contador a cada iteração
    
}
media = idade / contador; // Calcula a média das idades
Console.WriteLine($"A medias das idades é {media}");

// Outra forma de fazer o mesmo laço de repetição

int cont = -1; // Contador para o laço
double idade1 = 0; // Variável para armazenar a idade
double soma1 = 0; // Variável para armazenar a soma das idades

while (idade >= 0)
{
    soma1 += idade1;
    Console.WriteLine("Digite uma nova idade: ");
    idade1 = Convert.ToInt32(Console.ReadLine()); // Lê a nova idade
    cont++;
}
double media1 = soma1 / cont; // Calcula a média das idades
Console.WriteLine($"A média das idades é {media1}");





