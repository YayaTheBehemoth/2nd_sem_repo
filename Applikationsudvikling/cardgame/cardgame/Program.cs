using System;
using System.Collections.Generic;
using player_class;

namespace cardgame
{
    class Program
    {
        static void Main(string[] args)
        {
            //det giver ikke mening at lave en person subclass, en spiller i "krig" holder blot point og trækker kort 
            //initialiser to "Player" objekter som bruges til at holde point
            player a = new player("navn1");
            player b = new player("navn2");
            //initialiserer to deck objekter som skal bruges til spillet og kalder "shuffle" metoden
            
                deck_of_cards p1Deck = new deck_of_cards();
                deck_of_cards p2Deck = new deck_of_cards();
                p1Deck.shuffleDeck();
                p2Deck.shuffleDeck();
         
            //looper igennem deckene og kalder drawCard metoden som trækker et kort
            for (int i = p1Deck.cards.Count; i > 0; i--)
            {

                //sammenligner de to trukne kort 
                if ((p1Deck.drawCard().rank) > (p2Deck.drawCard().rank))
                {
                    a.addPoints();
                }
                else
                {
                    b.addPoints();

                }

            
            }
            //tømmer deckene når spillet er færdigt
            p1Deck.clear();
            p2Deck.clear();




            //printer pointstillingen og differencen 
            Console.WriteLine($"player 1 has {a.points} points");
           Console.WriteLine($"player 2 has {b.points} points");
                int pointDiff = 0;
                if (a.points > b.points)
                {
                    pointDiff = a.points - b.points;
                } else
                {
                    pointDiff = b.points - a.points;
                }
                Console.WriteLine($"the difference was {pointDiff}");

              
            
         
        
          
        }
    }
}
