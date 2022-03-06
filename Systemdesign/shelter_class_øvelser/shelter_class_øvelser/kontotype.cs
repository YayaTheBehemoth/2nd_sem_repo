using System;
namespace shelter_class_øvelser
{
    public class kontotype
    {
        private string _navn;
        private string _beskrivelse;
        private string _betingelser;

        public kontotype(string n, string bes, string bet)
        {
            _navn = n;
            _beskrivelse = bes;
            _betingelser = bet;
        }
        public string navn
        {
            get { return this._navn; }
        }
        public string beskrivelse
        {
            get { return this._beskrivelse; }
        }
        public string betingelser
        {
            get { return this._betingelser; }
        }
    }
}
