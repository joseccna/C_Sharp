Console.WriteLine("Quantas pessoas são maior de idade?");
int maiorDeIdade = 0;
int numeroDePessoas = 0; // Definindo o número de pessoas a serem verificadas
while (true)
{
    Console.Write("Digite a idade da pessoa: ");
    int idade = int.Parse(Console.ReadLine()!);
    if (idade >= 18)
    {
        maiorDeIdade++;
    }
    numeroDePessoas++; // Incrementa o número de pessoas verificadas
    if (numeroDePessoas == 8)
    {
        break; // Sai do loop quando o número de pessoas atinge 8
    }
}
Console.WriteLine($"O número de pessoas maiores de idade é: {maiorDeIdade}");
