using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cardgame
{
    public class deck_of_cards
    {
        private Stack<card> _cards = new Stack<card>();
        public Stack<card> cards
        {
            get { return _cards; }
            set { _cards = value; }
        }
        public deck_of_cards()
        {
          
            for (int i = 0; i < 3; i++)
            {
             
                for (int j = 2; j <= 14; j++)
                {
                    switch (i)
                    {
                        case 0:
                            card a = new card("heart", j);
                            _cards.Push(a);
                            break;
                        case 1:
                            card b = new card("club", j);
                            _cards.Push(b);
                            break;
                        case 2:
                            card c = new card("spade", j);
                            _cards.Push(c);
                            break;
                        case 3:
                            card d = new card("diamond", j);
                            _cards.Push(d);
                            break;

                    }
                   
                }
                 
            }
        }
        
        public Stack<card> shuffleDeck()
        {
            card[] shuffleArray = _cards.ToArray();
            Random rnd = new Random();
            for (int i = 0; i  < shuffleArray.Length -1; i++)
            {
                int j = rnd.Next(i, shuffleArray.Length);
                var temp = shuffleArray[i];
                shuffleArray[i] = shuffleArray[j];
                shuffleArray[j] = temp;
            }
            Stack<card> stack = new Stack<card>(shuffleArray);
            _cards = stack;
            return stack;
        }
        
        public card drawCard()
        {
            return _cards.Pop();
        }
        
    }
}
