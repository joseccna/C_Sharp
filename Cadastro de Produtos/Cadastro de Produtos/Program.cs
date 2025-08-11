Console.WriteLine("Cadastro de Produtos");
string[] produtos = new string[5];
double[] precos = new double[5];

for (int i = 0; i < produtos.Length; i++)
{
    Console.Write("Digite o nome do produto: ");
    produtos[i] = Console.ReadLine();
    
    Console.Write("Digite o preço do produto: ");
    precos[i] = Convert.ToDouble(Console.ReadLine());
    Console.Clear();
}
for (int i = 0; i < produtos.Length; i++)
{
    Console.WriteLine($"Produto: {produtos[i]}, Preço:R$ {precos[i]:C2}");
}