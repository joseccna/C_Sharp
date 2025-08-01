//Console.WriteLine("Estou aprendendo C# e .NET!");
//int idade = 40;
//string nome = "Jose";
//Console.WriteLine($"Meu nome é {nome}.");
//Console.WriteLine($"Minha idade é {idade} anos.");
//// numero real é double no csharp
//double altura = 1.80;

//DateTime dataNascimento = new DateTime(1983, 1, 1);
//DateTime dataAtual = DateTime.Now; // Data atual do sistema

//Console.WriteLine($"Minha altura é {altura} metros.");
//Console.WriteLine($"Data de nascimento: {dataNascimento.ToShortDateString()}");
//Console.WriteLine($"Data atual: {dataAtual.ToShortDateString()}");

//Console.WriteLine("digite seu nome:");
//string nomeUsuario = Console.ReadLine();
//Console.WriteLine($"Olá, {nomeUsuario}! Bem-vindo ao C# e .NET!");

//Console.WriteLine("teste de concatenação: " + dataAtual.ToLongDateString());
//Console.WriteLine("Digite sua idade: ");
//int idadeUsuario;
//idadeUsuario = int.Parse(Console.ReadLine() ?? "0"); // Lê a idade do usuário e converte para inteiro
//Console.WriteLine($"A sua idade é {idadeUsuario}");

//double alturaUsuario = 0; // Declaração implícita de variável com tipo double
//Console.WriteLine("Digite sua idade: ");
//alturaUsuario = double.Parse(Console.ReadLine() ?? "0.0"); // Lê a altura do usuário e converte para double
//Console.WriteLine($"A sua altura é {alturaUsuario} metros.");

//// Fazer uma operação matemática simples
//int num1 = 10;
//int num2 = 40;

//Console.WriteLine(num2 + num1); // Soma 
//Console.WriteLine($"{num1} , {num2} = {num1 + num2}"); // Soma com interpolação de string


// calcular imc

Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal)");
Console.WriteLine("Digite seu nome:");
string nomeUsuario = Console.ReadLine() ?? "Usuário";
Console.WriteLine("Digite sua altura em metros (ex: 1,75):");
double alturaUsuario = Convert.ToDouble(Console.ReadLine()) ; // Declaração implícita de variável com tipo double
//Console.WriteLine(alturaUsuario);
Console.WriteLine("Digite seu peso em kg (ex: 70):");
double peso = Convert.ToDouble(Console.ReadLine()); // Declaração implícita de variável com tipo double
//Console.WriteLine(peso);
double imc = peso / (alturaUsuario * alturaUsuario); // Cálculo do IMC
//Console.WriteLine(imc);
Console.WriteLine($"Olá, {nomeUsuario}! Seu IMC é: {imc:F2}"); // Exibe o IMC formatado com duas casas decimais
