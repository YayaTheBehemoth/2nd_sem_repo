using System;

namespace player_class
{
    
    class player
    {
        private string _name;
        private int _points;
    public player (string n)
        {
            _name = n;
            _points = 0;
        }
    public int points
        {
            get { return _points; }
        }
    public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
