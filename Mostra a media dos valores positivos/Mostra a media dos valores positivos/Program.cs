Console.WriteLine("Mostra as meida dos valores positivos");
Console.WriteLine("Digite os valores (digite 0 para terminar):");
int contador = 0;
double soma = 0.0;
while (true)
{
        double valor = Convert.ToDouble(Console.ReadLine());
    if (valor == 0) {
        break;
    }
    if (valor > 0) {
        soma += valor;
        contador++;
    }
}
double media =  soma / contador;
Console.WriteLine($"A média dos valores positivos é: {media}");
