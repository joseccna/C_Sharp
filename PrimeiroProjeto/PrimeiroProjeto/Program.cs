Console.WriteLine("Estou aprendendo C# e .NET!");
int idade = 40;
string nome = "Jose";
Console.WriteLine($"Meu nome é {nome}.");
Console.WriteLine($"Minha idade é {idade} anos.");
// numero real é double no csharp
double altura = 1.80;

DateTime dataNascimento = new DateTime(1983, 1, 1);
DateTime dataAtual = DateTime.Now; // Data atual do sistema

Console.WriteLine($"Minha altura é {altura} metros.");
Console.WriteLine($"Data de nascimento: {dataNascimento.ToShortDateString()}");
Console.WriteLine($"Data atual: {dataAtual.ToShortDateString()}");

Console.WriteLine("digite seu nome:");
string nomeUsuario = Console.ReadLine();
Console.WriteLine($"Olá, {nomeUsuario}! Bem-vindo ao C# e .NET!");
