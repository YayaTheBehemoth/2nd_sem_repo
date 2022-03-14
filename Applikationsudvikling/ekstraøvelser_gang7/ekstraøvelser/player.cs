using System;
namespace ekstraøvelser
{
    
    class player
    {
        //definerer felter for player class'en
        private string _name;
        private int _points;
        //laver konstruktøren, man kan selv vælge om der skal startes med at givent antal point eller 0 (default value)
    public player (string n,int p = 0)
        {
            _name = n;
            _points = p;
        }
        //definerer points, man kunne argumentere for at der ikke skal være en "set" her, da det jo tillader "svindel"
    public int points
        {
            get { return _points; }
            set { _points = value; }
        }
        //definerer name, samme argument kan rejses her som man kunne ved "points" men "name" variablen er dog mindre vigtig
    public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        //En metode til at tilføje et vilkårligt antal point, eller 1 (default value)
        public void addPoints(int p = 1)
        {
            points = points + p;
        }
    
    }
}
