// Condicionais if, else, else if

//Console.WriteLine("digite sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine("voce é maior de idade");
//}else
//{
//    Console.WriteLine("voce é menor de idade");
//}

////////////////////////////////////////////////////////

//Crie um verificador de aprovação para nota dos alunos.

//Console.WriteLine("Digite a nota do aluno: ");
//double nota = Convert.ToDouble(Console.ReadLine());

//if (nota >= 7)
//{
//    Console.WriteLine("Aluno aprovado!");
//}
//else if (nota >= 5)
//{
//    Console.WriteLine("Aluno em recuperação!");
//}
//else
//{
//    Console.WriteLine("Aluno reprovado!");
//}

/////////////////////////////////////////////////
// switch case

Console.WriteLine("Escola um pais pelo indeice: ");
Console.WriteLine("1 - Brasil");
Console.WriteLine("2 - Tailandia");
Console.WriteLine("3 - Alemanha");
int opcao = Convert.ToInt32(Console.ReadLine());

Console.Clear();

switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu o Brasil!");
        break;
    case 2:
        Console.WriteLine("Você escolheu a Tailândia!");
        break;
    case 3:
        Console.WriteLine("Você escolheu a Alemanha!");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;

}

