using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapayZeka
{
    public class caprazlama
    {
        public double firstgenA;
        public double firstgenXn;
        public double secondgenA;
        public double secondgenXn;

        public void Crossover()
        {
            parent newChild = new parent();
            newChild.ata(firstgenA, secondgenXn);
            newChild.ata(secondgenA, firstgenXn);
        }
    }
}
