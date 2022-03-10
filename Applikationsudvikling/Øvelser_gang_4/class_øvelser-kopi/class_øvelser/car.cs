using System;
namespace class_øvelser
{
    public class car : Vehicle
    {
        private int _noOfSeats;
        private int _noOfDoors;
        public car(string r, string c, Int32 y, string make, string model, int ns, int nd) : base(r, c, y, make, model)
        {
            _noOfSeats = ns;
            _noOfDoors = nd;
        }
        public int noOfDoors
        {
            get { return _noOfDoors; }

        }
        public int noOfSeats
        {
            get { return _noOfDoors; }
            set { _noOfDoors = value; }
        }
    }
}
