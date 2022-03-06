using System;
namespace shelter_class_øvelser
{
    public class transaktioner
    {
        private int _beløb;
        private DateTime _dato;

        public transaktioner(int b)
        {
            _beløb = b;
            _dato = DateTime.Now;
        }

        public int beløb
        {
            get { return _beløb; }
            set { _beløb = value; }
        }

        public DateTime dato
        {
            get { return _dato; }
            set { _dato = value; }
        }
    }
}
