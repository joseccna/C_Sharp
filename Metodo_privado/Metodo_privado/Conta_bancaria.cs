using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_privado
{
    internal class Conta_bancaria
    {
        private string titular = "";
        private double saldo = 0.0;

        // dia 20-08-2025
        // Método Get Set para modificar atributos privados.

        public double saldoAtual
        {
            get { return saldo; } // Permite acesso ao saldo, mas não permite modificação direta
            private set
            {
                if (value >= 0)
                {
                    saldo = value; // Permite apenas valores não negativos
                }
            }
        }



        //////////////////////////////////
        // Metodo inicial para acessar atributos privados.

        public void Titular(string nome)
        {
            titular = nome;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
            }
        }

        //public double ObterSaldo()
        //{
        //    return saldo;
        //}

        public string Titular1
        {
            get { return titular; }

        }


    }

}
