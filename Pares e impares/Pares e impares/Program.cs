Console.WriteLine("Contador de pares e ímpares");

double[] numeros = new double[6];
double pares = 0, impares = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = Convert.ToDouble(Console.ReadLine());
    if (numeros[i] % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}
Console.WriteLine($"Você digitou {pares} números pares e {impares} números ímpares.");
