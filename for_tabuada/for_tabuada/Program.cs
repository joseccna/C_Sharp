Console.WriteLine("Tabuada");
Console.Write("Digite um número para gerar a tabuada: ");
int tabuada = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    int resultado = tabuada * i;
    Console.WriteLine($"{tabuada} x {i} =  {resultado}");
}
