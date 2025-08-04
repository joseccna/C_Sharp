Console.WriteLine("Media do aluno!");
Console.Write("Digite o nome do aluno: ");
string nomeAluno = Console.ReadLine() ?? "";
Console.Write("Digite a primeira nota: ");
double notaA = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
double notaB = Convert.ToDouble(Console.ReadLine());
double mediaTotal = (notaA + notaB) / 2;

Console.WriteLine($"A média do aluno {nomeAluno} é: {mediaTotal:F1}");
switch (mediaTotal)
{
    case >= 9 and <= 10:
            Console.WriteLine($"O aluno {nomeAluno} está aprovado com conceito A");
        break;
    case >= 8 and <= 8.9:
            Console.WriteLine($"O aluno {nomeAluno} está aprovado com conceito B");
        break;
    case >= 7 and <= 7.9:
            Console.WriteLine($"O aluno {nomeAluno} está aprovado com conceito C");
        break;
    case >= 5 and <= 6.9:
            Console.WriteLine($"O aluno {nomeAluno} está recuperação com conceito D");
        break;
    default:
            Console.WriteLine($"O aluno {nomeAluno} está reprovado com conceito F");
        break;

}


/////////////////////////////////////////////////
// Correção

//Console.WriteLine("Digite o nome do aluno:");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite a primeira nota:");
//double nota1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Digite a segunda nota:");
//double nota2 = Convert.ToDouble(Console.ReadLine());

//double media = (nota1 + nota2) / 2;

//Console.WriteLine($"Aluno: {nome}. Sua média é: {media}");

//if (media >= 7)
//{
//    Console.WriteLine("Status de aluno: APROVADO!");
//}
//else if (media >= 5)
//{
//    Console.WriteLine("Status de aluno: RECUPERAÇÃO!");
//}
//else
//{
//    Console.WriteLine("Status de aluno: REPROVADO!");
//}

//int convertido = (int)Math.Floor(media);

//switch (convertido)
//{
//    case 10:
//        Console.WriteLine("Classificação de média: A");
//        break;
//    case 9:
//        Console.WriteLine("Classificação de média: A");
//        break;
//    case 8:
//        Console.WriteLine("Classificação de média: B");
//        break;
//    case 7:
//        Console.WriteLine("Classificação de média: C");
//        break;
//    case 6:
//        Console.WriteLine("Classificação de média: D");
//        break;
//    case 5:
//        Console.WriteLine("Classificação de média: D");
//        break;
//    case 4:
//        Console.WriteLine("Classificação de média: F");
//        break;
//    case 3:
//        Console.WriteLine("Classificação de média: F");
//        break;
//    case 2:
//        Console.WriteLine("Classificação de média: F");
//        break;
//    case 1:
//        Console.WriteLine("Classificação de média: F");
//        break;
//}