using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHeranca
{
    internal class Gerente : Funcionario
    {
        public double Salario;
        public override double Comissao()
        {
            return base.Comissao() * 0.05;
        }

    }
}
