using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHeranca
{
    internal class Vendedor : Funcionario
    {
        public int ID;
        public override double Comissao()
        {
            return base.Comissao() *  0.10;
        }
    }
}
