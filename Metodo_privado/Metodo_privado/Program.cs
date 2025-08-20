using System;
using System.Security.Cryptography.X509Certificates;
using Metodo_privado;

class Program
{
     public static void Main(string[] args)
     {
        Conta_bancaria conta = new Conta_bancaria();
        conta.Titular("João da Silva");
        conta.Depositar(1000.0);
        conta.Sacar(200.0);

        Console.WriteLine($"Titular: {conta.Titular1}"); // Exibe o titular da conta
        Console.WriteLine($"Saldo atual: {conta.saldoAtual}"); // Exibe o saldo atual
    }
}