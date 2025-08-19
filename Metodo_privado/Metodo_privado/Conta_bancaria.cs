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

        public double ObterSaldo()
        {
            return saldo;
        }

        public string Titular1
        {
            get { return titular; }


        }

    }
}
