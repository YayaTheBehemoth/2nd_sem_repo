using System;

namespace cardgame
{
    class Program
    {
        static void Main(string[] args)
        {

        static string warGame()
            {
               
               int p1Points = 0;
                int p2Points = 0;
                deck_of_cards p1Deck = new deck_of_cards();
                deck_of_cards p2Deck = new deck_of_cards();
                p1Deck.shuffleDeck();
                p2Deck.shuffleDeck();
                for (int i = 0; i < 52; i++)
                {
                     if ((p1Deck.drawCard().rank)> (p2Deck.drawCard().rank))
                    {
                        p1Points = p1Points + 1; 
                    } else  {
                        p2Points = p2Points + 1;
                    } 
                }
                if (p1Points > p2Points)
                {
                   
                }

            }
         
        
          
        }
    }
}
