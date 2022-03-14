using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ekstraøvelser
{
    public class deck_of_cards
    {
        private Stack<Bjcard> _cards = new Stack<Bjcard>();
        public Stack<Bjcard> cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
        public deck_of_cards()
        {
          
            for (int i = 0; i <= 3; i++)
            {
             
                for (int j = 2; j <= 14; j++)
                {
                    switch (i)
                    {
                        case 0:
                            Bjcard a = new Bjcard("heart", j);
                            _cards.Push(a);
                            break;
                        case 1:
                            Bjcard b = new Bjcard("club", j);
                            _cards.Push(b);
                            break;
                        case 2:
                            Bjcard c = new Bjcard("spade", j);
                            _cards.Push(c);
                            break;
                        case 3:
                            Bjcard d = new Bjcard("diamond", j);
                            _cards.Push(d);
                            break;

                    }
                   
                }
                 
            }
        }
        
        public Stack<Bjcard> shuffleDeck()
        {
            Bjcard[] shuffleArray = _cards.ToArray();
            Random rnd = new Random();
            for (int i = 0; i  < shuffleArray.Length -1; i++)
            {
                int j = rnd.Next(i, shuffleArray.Length);
                var temp = shuffleArray[i];
                shuffleArray[i] = shuffleArray[j];
                shuffleArray[j] = temp;
            }
            Stack<Bjcard> stack = new Stack<Bjcard>(shuffleArray);
            _cards = stack;
            return stack;
        }
        
        public Bjcard drawCard()
        {
            return _cards.Pop();
        }

        public void clear()
        {
            _cards.Clear();
        }
        
    }
}
