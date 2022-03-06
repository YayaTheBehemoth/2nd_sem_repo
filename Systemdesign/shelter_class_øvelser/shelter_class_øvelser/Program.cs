using System;

namespace shelter_class_øvelser
{
    class Program
    {
        static void Main(string[] args)
        {
            //methods that demonstrates shelterclasses
            shelter a = new shelter(1, 1, "nice", 1, 1);
            a.getInfo();
            a.bookShelter();
            a.getInfo();
            //as the code above amply demonstrates, shid worked 
            kontotype b = new kontotype("bidness", "shid", "shid");
            kontotype c = new kontotype("private", "shud", "shid");
            konto d = new konto(b);
            konto e = new konto(c);
            d.indsætBeløb(100);
            e.indsætBeløb(100);
            d.beregnSaldo();
            e.beregnSaldo();
            d.indsætBeløb(1000);
            e.indsætBeløb(1000);
            d.beregnSaldo();
            e.beregnSaldo();
           

        }
    }
}
