Console.WriteLine("Media do aluno!");
Console.Write("Digite o nome do aluno: ");
string nome = Console.ReadLine() ?? "";
Console.Write("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
double media = (nota1 + nota2) / 2;

Console.Clear();

switch (media)
{
    case >=9 and <=10:
        Console.WriteLine($"O aluno {nome} está aprovado com conceito A");
        break;
    case >=8 and <8.9:
            Console.WriteLine($"O aluno {nome} está aprovado com conceito B");
        break;
    case >=7 and <7.9:
            Console.WriteLine($"O aluno {nome} está aprovado com conceito C");
        break;
        case >=5 and <6.9:
            Console.WriteLine($"O aluno {nome} está recuperação com conceito D");
        break;
    default:
                Console.WriteLine($"O aluno {nome} está reprovado com conceito F");
        break;

}
