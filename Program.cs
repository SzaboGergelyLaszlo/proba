using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace celloveszetCLI
{
    public class Program
    {
        //8. feladat
        public static int Legnagyobb(int a, int b, int c, int d)
        {
            int Legnagyobb = a;
            List<int> lovesek = new List<int>();
            lovesek.Add(a);
            lovesek.Add(b);
            lovesek.Add(c);
            lovesek.Add(d);
            foreach (var i in lovesek)
            {
                if (i > Legnagyobb)
                {
                    Legnagyobb = i;
                }
            }

            return Legnagyobb;
        }

         static List<Lovo> lovok = new List<Lovo>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("lovesek.csv");
            while (!sr.EndOfStream)
            {
                lovok.Add(new Lovo(sr.ReadLine()));
            }
            sr.Close();

            //9.feladat
            foreach (var i in lovok)
            {
                Console.WriteLine(i.Nev + " " + Legnagyobb(i.ElsoLoves, i.MasodikLoves, i.HarmadikLoves, i.NegyedikLoves));
            }

            //10. feladat

            int index = 0;
            for (int i = 0; i < lovok.Count; i++)
            {
                if (Legnagyobb(lovok[index].ElsoLoves, lovok[index].MasodikLoves, lovok[index].HarmadikLoves, lovok[index].NegyedikLoves) < Legnagyobb(lovok[i].ElsoLoves, lovok[i].MasodikLoves, lovok[i].HarmadikLoves, lovok[i].NegyedikLoves))
                {
                    index = i;
                }
            }

            //11.feladat

            int indexAtlag = 0;

            for (int i = 0; i < lovok.Count; i++)
            {
                if (Lovo.atlag(lovok[indexAtlag]) > Lovo.atlag(lovok[i]))
                {
                    indexAtlag = i;
                }
            }
            

            Console.WriteLine("A legnagyobb találatott elért eredményei: " + lovok[index].ToString());
            Console.WriteLine("A legkisebb átlagú eredményei: " + lovok[indexAtlag].Nev + " " + Lovo.atlag(lovok[indexAtlag]));
            Console.ReadKey();
        }
    }
}
