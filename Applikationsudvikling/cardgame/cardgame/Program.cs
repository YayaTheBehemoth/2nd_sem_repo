using System;
using System.Collections.Generic;

namespace cardgame
{
    class Program
    {
        static void Main(string[] args)
        {
            
               
               int p1Points = 0;
                int p2Points = 0;
                deck_of_cards p1Deck = new deck_of_cards();
                deck_of_cards p2Deck = new deck_of_cards();
                p1Deck.shuffleDeck();
                p2Deck.shuffleDeck();
                for (int i = p1Deck.cards.Count; i > 0; i--)
            {
                
                if ((p1Deck.drawCard().rank) > (p2Deck.drawCard().rank))
                {
                    p1Points = p1Points + 1;
                }
                else
                {
                    p2Points = p2Points + 1;
                }
            }
            p1Deck.clear();
            p2Deck.clear();

               /*
                foreach (card n in p1Deck.cards)
                {
                     if ((p1Deck.drawCard().rank)> (p2Deck.drawCard().rank))
                    {
                        p1Points = p1Points + 1; 
                    } else  {
                        p2Points = p2Points + 1;
                    } 
                }
               */

            
                Console.WriteLine($"player 1 has {p1Points} points");
                Console.WriteLine($"player 2 has {p2Points} points");
                int pointDiff = 0;
                if (p1Points > p2Points)
                {
                    pointDiff = p1Points - p2Points;
                } else
                {
                    pointDiff = p2Points - p1Points;
                }
                Console.WriteLine($"the difference was {pointDiff}");

              
            
         
        
          
        }
    }
}
