using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegyzetOsztaly
{
    class Negyzet
    {
        private int oldal;

        public Negyzet(int oldal)
        {
            if (oldal > 0)
                this.oldal = oldal;
            else
                throw new Exception("Negatív oldalú négyzet nincs.");
        }
        public int getTerulet()
        {
            int terulet = oldal * oldal;
            return terulet;
        }
        public int getKerulet()
        {
            int kerulet = 4 * oldal;
            return kerulet;
        }
        public override string ToString()
        {
            return "Négyzet oldala: " + oldal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
