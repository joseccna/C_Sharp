
Console.WriteLine("Cadastro pessoal!");
Console.WriteLine("Digigte seu nome: ");
string nome = Console.ReadLine() ?? "";
Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine() );
Console.WriteLine("Digite sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Olá {nome}! Voce tem {idade} anos e mede {altura}.");

