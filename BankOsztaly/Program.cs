using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOsztaly
{
    class Szamla
    {
        private int egyenleg;
        public Szamla()
        {
            this.egyenleg = 0;
        }
        public Szamla(int nyitoOsszeg)
        {
            if (nyitoOsszeg >= 0)
                this.egyenleg = nyitoOsszeg;
            else
                throw new Exception("Számlát nem lehet nyitni negatív pénzösszeggel!");
        }
        public override string ToString()
        {
            return "Egyenleg: " + egyenleg;
        }
        public void befizetSzamlara(int osszeg)
        {
            if (osszeg > 0)
            {
                egyenleg += osszeg;
            }
            else
                throw new Exception("Számlára nulla vagy negatív összeget nem lehet befizetni!");
        }
        public bool kiveszSzamlarol(int osszeg)
        {
            if (osszeg < egyenleg)
            {
                egyenleg -= osszeg;
                return true;
            }
            else
                throw new Exception("Csak akkora összeget lehet kivenni a számláról, amennyi a számlán van, többet nem!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Szamla a = new Szamla(100);
                Console.WriteLine(a);
                Szamla b = new Szamla(-10);
                a.befizetSzamlara(-5);
                a.kiveszSzamlarol(300);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
