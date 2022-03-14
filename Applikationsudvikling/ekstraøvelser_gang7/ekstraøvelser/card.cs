using System;
namespace ekstraøvelser
{
    public class card
    {
        public string _suit;
        public int _rank;
        public card(string s,int r)
        {
            if (r < 2 || r > 14)
            {
                throw new Exception(r + "is not a vaid input, please pick a value between 2 and 14");
            } else
            {
                _rank = r;
            }
            bool result = (s.Equals("Heart", StringComparison.OrdinalIgnoreCase) || s.Equals("Spade", StringComparison.OrdinalIgnoreCase) || s.Equals("Club", StringComparison.OrdinalIgnoreCase) || s.Equals("Diamond", StringComparison.OrdinalIgnoreCase));
            if (result == true) {
                _suit = s;
            } else
            {
                throw new Exception("please pick a valid symbol");
            }
            
           
         }

        public override string ToString()
        {
            string number ="";
            if (_rank >= 11)
            {
                switch(_rank) {
                    case 11:
                        number = "Jack";
                        break;
                    case 12:
                        number = "Queen";
                        break;
                    case 13:
                        number = "king";
                        break;
                    case 14:
                        number = "Ace";
                        break;
                 
                }
                

                
            }else
            {
                number = _rank.ToString();
            }
            string rankAndSuit = $"{_suit} {number}";
            return rankAndSuit;
        }

        public string suit
        {
            get { return _suit; }
        }
        public int rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

    }
        
 }
    




