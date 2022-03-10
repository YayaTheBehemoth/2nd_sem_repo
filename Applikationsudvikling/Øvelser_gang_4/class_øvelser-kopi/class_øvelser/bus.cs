using System;
namespace class_øvelser
{
    public class bus : Vehicle
    {
        private int _noOfPassengers;
        public bus(string r, string c, Int32 y, string make, string model, int nop) : base(r, c, y, make, model)
        {
            _noOfPassengers = nop;
        }
        public int noOfPassengers
        {
            get { return _noOfPassengers; }
            set { _noOfPassengers = value; }
        }
    }
}
