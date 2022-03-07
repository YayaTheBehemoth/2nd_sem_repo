using System;
namespace shelter_class_øvelser
{
    public class område
    {
        private int _område_id;
        private string _navn;
        private string _adresse;
        private string _beskrivelse;
        private int[] _koords = new kords[2];
        public område(int oi, string n, string a, string b, int k [])
        {
            _område_id = oi;
            _adresse = a;
            _beskrivelse = b;
            _navn = n;
            foreach (int n in k)
            {
                _koords.[n] = new kords.(n) ;
            }
        }
        public int område_id
        {
            get { return _område_id; }
        }
        public string navn
        {
            get { return _navn; }
        }
        public string beskrivelse
        {
            get { return _adresse; }
        }
        public int [] koords
        {
            get { return _koords; }
        }
        public void getInfo()
        {
            Console.WriteLine($"navn:{navn}");
            Console.WriteLine($"beskrivelse:{beskrivelse}");
            Console.WriteLine($"adresse:{adresse}");
            Console.WriteLine($"Koordinater:{koords}");
        }
    }
}
