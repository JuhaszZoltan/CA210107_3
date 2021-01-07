using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210107_3
{
    class Horcsog
    {
        public string Nev { get; set; }
        public float Suly { get; set; }
        public float Hossz { get; set; }
        public DateTime? SzuliNap { get; set; }
        public ConsoleColor Szin { get; set; }
        public bool Sex { get; set; }

        public Horcsog(string nev, float suly, float hossz, DateTime? szuliNap, ConsoleColor szin, bool sex)
        {
            Nev = nev;
            Suly = suly;
            Hossz = hossz;
            SzuliNap = szuliNap;
            Szin = szin;
            Sex = sex;
        }

        public Horcsog(float suly, float hossz, ConsoleColor szin, bool sex)
            : this(null, suly, hossz, null, szin, sex) { }

        public Horcsog(string nev) 
            : this(nev, 0F, 0F, null, ConsoleColor.Green, false) { }

        public Horcsog() 
            : this("Nincs", 0F, 0F, null, ConsoleColor.Green, false) { }
    }

    class Capa
    {
        public string Nev { get; set; }
        public float Suly { get; set; }
        public float Hossz { get; set; }
        public DateTime? SzuliNap { get; set; }
        public ConsoleColor Szin { get; set; }
        public bool Sex { get; set; }

        public Capa(string nev, float suly, float hossz)
        {
            Nev = nev;
            Suly = suly;
            Hossz = hossz;
        }

        public Capa(string nev, float suly, float hossz, DateTime? szuliNap, ConsoleColor szin) 
            : this(nev, suly, hossz)
        {
            SzuliNap = szuliNap;
            Szin = szin;
            Sex = true;
        }

        public Capa(string nev, float suly, float hossz, DateTime? szuliNap, ConsoleColor szin, bool sex)
            : this(nev, suly, hossz, szuliNap, szin)
        {
            Sex = sex;
        }
    }

    class Program
    {
        static void Main()
        {
            //OVERLOADING: létezhetnek egy classon belül azonos nevű metódusok,
            //amennyiben a paraméterlistájuk egyértelműen megküönböztethető

            //var h = new Horcsog(
            //    nev: "Kármen", 
            //    hossz: 8F,
            //    suly: 0.2F,
            //    szin: ConsoleColor.Magenta,
            //    sex: false,
            //    szuliNap: new DateTime(2020, 12, 04));


            //var h2 = new Horcsog();
            //Console.WriteLine(h2.Nev);
            //Console.ReadKey();


            var h = new Capa(
                nev: "Kármen",
                hossz: 2F,
                suly: 140F,
                szin: ConsoleColor.DarkRed,
                sex: true,
                szuliNap: new DateTime(1862, 03, 14));
        }
    }
}
