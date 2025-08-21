using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHeranca
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }



        public virtual double Comissao()
        {
            return 5000;
        }

    }
}
