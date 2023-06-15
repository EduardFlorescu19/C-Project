using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ConcreteCredit : Credit
    {
        public ConcreteCredit(int id, string numeClient, decimal sumaImprumutata, int durataInLuni, decimal dobandaAnuala)
        : base(id, numeClient, sumaImprumutata, durataInLuni, dobandaAnuala)
        {
        }

        public override decimal CalculeazaDobanda()
        {
            return DobandaAnuala;
        }
    }
}
