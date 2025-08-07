Console.WriteLine("Cadostro de Alunos com Média");
string[] alunos = new string[5];
double[] notas1 = new double[5];


for (int i =0; i <= 4; i++)
{
    Console.WriteLine("Digite o nome do aluno!");
    alunos[i] = Console.ReadLine() ??"";
    Console.WriteLine("Digite a nota do aluno!");
    notas1[i] = Convert.ToDouble(Console.ReadLine());
    Console.Clear();

}
Console.WriteLine("Alunos e suas notas:");
for (int i = 0; i <= 4; i++)
{
    Console.WriteLine($"Aluno: {alunos[i]} , Nota: {notas1[i]}");
}
