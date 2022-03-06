using System;
using System.Collections.Generic;
namespace shelter_class_øvelser
{
    public class konto
    {
        private int _nr;
        private kontotype _kontotype;
        private List<transaktioner> _transaktioner = new List<transaktioner>();

    public konto (kontotype k)
        {
            _kontotype = k;
            Random rnd = new Random();
            _nr = rnd.Next(1, 100);

        }
    public int nr
        {
            get { return _nr; }
        }
    public kontotype kontotype
        {
            get { return _kontotype; }
        }
    public List<transaktioner> transaktioner
        {
            get { return _transaktioner; }
            set { _transaktioner = value; }
        }
    public void indsætBeløb(int b)
        {

            Console.WriteLine($"{b} was inserted into your account");
            transaktioner.Add(new transaktioner(b));
           
        }
    public kontotype getKontotype()
        {
            return this.kontotype;
        }
    public void beregnSaldo()
        {
            int saldo = 0;
            foreach (var transaktioner in _transaktioner)
            {
                saldo = saldo + transaktioner.beløb;
            }
            Console.WriteLine($"din saldo er {saldo}");
        }
    }
}
