using System;

namespace ekstraøvelser
{
    class Program
    {
        /*  7.06
        static void Main(string[] args)
        {
            Console.WriteLine(minConvert(2));
            Console.WriteLine(bdayConvert(5));
            Console.WriteLine(vibeCheck(5));
            Console.WriteLine(vibeCheck(-5));
        }
        static int minConvert(int i)
        {
            int secs = i * 60;
            return secs;
        }
        static int bdayConvert(int i)
        {
            int secs = i * 365;
            return secs;
        }
        static bool vibeCheck(int i)
        {
            
            if (0 > i)
            {
               return true;
            }
            return false;
        }
        */
        static void Main(string[] args)
        {
            bjplayer player = new bjplayer("player");
            bjplayer dealer = new bjplayer("dealer");
            deck_of_cards a = new deck_of_cards();
            a.shuffleDeck();
            while(a.cards.Count > 0)
            {
                player.card0 = a.drawCard();
                player.card1 = a.drawCard();
                dealer.card0 = a.drawCard();
                dealer.card1 = a.drawCard();
                Console.WriteLine($"Type 'hit' if you want to hit, type litteraly anything else to stand, keep in mind your current hand is worth {player.countHand()}");
                string choice = Console.ReadLine();
                if (choice.Equals("hit", StringComparison.OrdinalIgnoreCase))
                {
                    player.card2 = a.drawCard();

                }
                if (dealer.countHand() < 17)
                {
                    dealer.card2 = a.drawCard();
                }
                   if (player.card0.rank == 14)
                {
                    player.convertAce(player.card0);
                }
                if (player.card1.rank == 14)
                {
                    player.convertAce(player.card1);
                }
                if (!(player.card2 == null))
                {
                    if (player.card2.rank == 14)
                    {
                        player.convertAce(player.card2);
                    }
              
                }
                if (dealer.card0.rank == 14)
                {
                    dealer.convertAce(dealer.card0);
                }
                if (dealer.card1.rank == 14)
                {
                    dealer.convertAce(dealer.card1);
                }
                if (!(dealer.card2 == null))
                {
                    if(dealer.card2.rank == 14)
                    {
                        dealer.convertAce(dealer.card2);
                    }
       
                }

                
                

                if (player.countHand() > dealer.countHand())
                {
                    if (player.countHand() > 21)
                    {
                        dealer.addPoints();
                        Console.WriteLine("the value of your hand exceeded 21 and you didnt get any points, but the dealer did");
                    } else if (player.countHand()< 21)
                    {
                        player.addPoints();
                       
                    }
                    Console.WriteLine($"player score {player.points}");
                    Console.WriteLine($"Dealer score {dealer.points}");


                    player.emptyHand();
                    dealer.emptyHand();
                    continue;
                }
                else if (dealer.countHand() > player.countHand())
                {
                    if (dealer.countHand() > 21)
                    {
                        player.addPoints();
                        Console.WriteLine("the value of the dealers hand exceeded 21 and you get points");
                    }
                    else if (player.countHand() < 21)
                    {
                        player.addPoints();
                        
                    }
                    Console.WriteLine($"player score {player.points}");
                    Console.WriteLine($"Dealer score {dealer.points}");

                    player.emptyHand();
                    dealer.emptyHand();
                    continue;
                }
             
            }
        }
    }
}
