using System;
namespace shelter_class_øvelser
{
    public class shelter
    {
        //fields of the shelter-class
        private int _shelter_id;
        private int _område_id;
        private string _navn;
        private int _tilladte_gæster;
        private int _areal;
        private Boolean _tilgængelighed;
        //constructor, you could arguebly make any given number of constructors
        //I've not done that since im giga lazy
        //only important thing to keep in mind is that
        //the constructor is made in accordance with
        //whatever constraints you might have on the attributes (ex. do not make a constructor that omits a parameter with a not-null constraint)
        public shelter(int si, int oi, string n, int tg, int a)
        {
            _shelter_id = si;
            _område_id = oi;
            _navn = n;
            _tilladte_gæster = tg;
            _areal = a;
            _tilgængelighed = true;
        }

        //attributes of the shelter class
        public int shelter_id
        {
            get { return this._shelter_id; }
        }
        public int område_id
        {
            get { return this._område_id; }
        }
        public string navn
        {
            get { return this._navn; }
        }
        public int tilladte_gæster
        {
            get { return this._tilladte_gæster; }
        }
        public int areal
        {
            get { return this._areal; }
        }
        public Boolean tilgængelighed
        {
            get { return this._tilgængelighed; }
        }

        //generic method that fetches all info from a given object
        public void getInfo()
        {
            Console.WriteLine($"navn:{navn}");
            Console.WriteLine($"område:{område_id}");
            Console.WriteLine($"areal:{areal}");
            Console.WriteLine($"tilgængelig:{tilgængelighed}");
            Console.WriteLine($"tilladte gæster:{tilladte_gæster}");
            
        }
        //changes "tilgængelighed" value
        public void bookShelter()
        {
            _tilgængelighed = false;
            Console.WriteLine($"{this.navn} er nu blevet booket");
            
        }
        //changes "tilgængelighed" value if it is false 
        public void unbookShelter()
        {
            if (_tilgængelighed == false)
            {
                _tilgængelighed = true;
                Console.WriteLine($"din bookning af {this.navn} er nu blevet anulleret");
            } else
            {
                Console.WriteLine($"Du kan ikke unbooke en shelter som ikke er booket");
            }
            

        }
    }
}
