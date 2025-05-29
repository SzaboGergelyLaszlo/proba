using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetWPF
{
    class Lovo
    {
        public string Nev { get; private set; }

        public int ElsoLoves { get; private set; }

        public int MasodikLoves { get; private set; }
        public int HarmadikLoves { get; private set; }
        public int NegyedikLoves { get; private set; }

        public Lovo(string sor)
        {
            string[] sorok = sor.Split(';');
            this.Nev = sorok[0];
            this.ElsoLoves = Convert.ToInt32(sorok[1]);
            this.MasodikLoves = Convert.ToInt32(sorok[2]);
            this.HarmadikLoves = Convert.ToInt32(sorok[3]);
            this.NegyedikLoves = Convert.ToInt32(sorok[4]);
        }



        public override string ToString()
        {
            return $"{this.Nev} {this.ElsoLoves} {this.MasodikLoves} {this.HarmadikLoves} {this.NegyedikLoves}";
        }

        public static int atlag(Lovo lovo)
        {
            int osszeg = lovo.ElsoLoves + lovo.MasodikLoves + lovo.HarmadikLoves + lovo.NegyedikLoves;
            return (osszeg / 4);
        }
    }
}
