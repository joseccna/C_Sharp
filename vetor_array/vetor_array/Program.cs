// Vetor

//int[] numero = new int[5];

//numero[0] = 10;
//numero[1] = 20;
//numero[2] = 30;
//numero[3] = 40;
//numero[4] = 50;

//for (int i = 0; i < numero.Length; i++)
//{
//    Console.WriteLine($"Posição {i} = {numero[i]}");
//}

/////////////////// outra forma de declarar vetor

//string[] nome = new string[3] { "maria", "João", "Ana" };
//for (int i =0; i < nome.Length; i++)
//{
//    Console.WriteLine($"Posição {i} = {nome[i]}");
//}

////////////////// outra forma de percorrer vetor

//string[] nome = new string[3] { "maria", "João", "Ana" };

//foreach (string n in nome)
//{
//    Console.WriteLine(n);
//}

/////////////////// nota

double[] nota = new double[3];

for (int i = 0; i < nota.Length; i++)
{
    Console.Write($"Digite a nota {i + 1}: ");
    nota[i] = Convert.ToDouble(Console.ReadLine());

    Console.Clear();
}

Console.WriteLine("Notas digitadas: ");

for (int i = 0; i < nota.Length; i++)
{
    Console.WriteLine($"Nota {i + 1} = {nota[i]}");
}

