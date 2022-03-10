using System;
namespace class_øvelser
{
    public class truck : Vehicle
    {
        private int _maxLoad;
        private int _totalWeight;

        public truck(string r, string c, Int32 y, string make, string model,int ml,int tw) :base ( r, c, y, make,  model)
        {
         _totalWeight = tw;
            _maxLoad = ml;

        }
        public int maxLoad
        {
            get { return _maxLoad; }
           
        }

        public int totalWeight
        {
            get { return _totalWeight; }
        }
    }
}
