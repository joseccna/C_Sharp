Console.WriteLine("Cadastre sua senha:");
string senha = Console.ReadLine() ??"";
Console.Clear();
Console.WriteLine("Digite a senha:");
do
{
    string login = Console.ReadLine() ?? "";
    if (login == senha)
    {
        Console.WriteLine("Senha correta. Acesso concedido.");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Senha incorreta. Tente novamente:");
    }


    

} while (true);

