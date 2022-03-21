using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{

    class Balkezesek
    {
        public Balkezesek(string sor)
        {
            string[] sorelemek = sor.Split(';');
            this.Nev = sorelemek[0];
            this.Elso = Convert.ToDateTime(sorelemek[1]);
            this.Utolso = Convert.ToDateTime(sorelemek[2]);
            this.Suly = Convert.ToInt32(sorelemek[3]);
            this.Magassag = Convert.ToInt32(sorelemek[4]);

        }
        
        public string Nev { get; set; }
        public DateTime Elso { get; set; }
        public DateTime Utolso { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

    }
    class Program
    {
        public static List<Balkezesek> adatok = new List<Balkezesek>();
        static void Main(string[] args)
        {
            StreamReader olvas = new StreamReader("balkezesek.csv", Encoding.UTF8);
            string fejlec = olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                adatok.Add(new Balkezesek(olvas.ReadLine()));
            }
            int i, j;
            int adatokszama = adatok.Count;
            //3
            Console.WriteLine("3. feladat: {0}", adatokszama);
                        
            //4
            Console.WriteLine("4. feladat:");
            for (i = 0; i < adatokszama; i++)
                if (adatok[i].Utolso.Year == 1999 && adatok[i].Utolso.Month == 10)
                    Console.WriteLine("\t{0}, {1} cm", adatok[i].Nev, Math.Round(adatok[i].Magassag * 2.54, 1));

            

            
                    

                    Console.ReadKey();
        }
    }
}
