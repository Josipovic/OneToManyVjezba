using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyVjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            BolnicaContext db = new BolnicaContext();
            Bolnica b = new Bolnica();
            b.NazivBolnice = "Rebro";
            b.Adresa = "Prva adresa";
            Bolnica b1 = new Bolnica();
            b1.NazivBolnice = "Bubreg";
            b1.Adresa = "Druga adresa";

            Doktori d = new Doktori();
            d.Ime = "Ivo";
            d.Prezime = "Ivic";
            d.Specijalizacija = "Kirurg";
            Doktori d1 = new Doktori();
            d1.Ime = "Pero";
            d1.Prezime = "Peric";
            d1.Specijalizacija = "Pedijatar";
            Doktori d2 = new Doktori();
            d2.Ime = "Mario";
            d2.Prezime = "Matic";
            d2.Specijalizacija = "oftamolog";

            db.Bolnice.Add(b);
            db.Bolnice.Add(b1);
            b.Doktori.Add(d);
            b.Doktori.Add(d1);
            b1.Doktori.Add(d2);
            //db.SaveChanges();

            //foreach (var m in db.Bolnice) {
            //    Console.WriteLine(m.NazivBolnice + "  " + m.Adresa);
            //    foreach (var k in m.Doktori) {
            //        Console.WriteLine("    " + k.Ime + "  " + k.Prezime + "  " + k.Specijalizacija);
            //    }
            //}


            foreach (var a in db.Doktori) {
                Console.WriteLine(a.Ime + " " + a.Bolnica.NazivBolnice);
            }

            Console.Read();


        }
    }
}
