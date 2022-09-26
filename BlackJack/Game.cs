using System;
namespace BlackJack {
    class Game {
        Deck deck;
        public Game() {
            deck = new Deck();
        }

        public void Play() {
            Player player = new Player();
            Hand playerHand = player.Deal(deck);

            if(playerHand.IsBusted()){
                Console.WriteLine("You dun fucked up, son!");
                Console.WriteLine("Game Over!");
                return;
            }
            else{
                Console.WriteLine("Player stays at {0}", playerHand.Total());
            }

            Console.WriteLine();
            Console.WriteLine("Dealer Playing");

            Dealer dealer = new Dealer();
            Hand dealerHand = dealer.Deal(deck);

            Console.WriteLine();
            if(dealerHand.IsBusted()){
                Console.Write("Dealer busted!");
                Console.WriteLine("Player Wins!");
                return;
            }

            Console.WriteLine();
            if(playerHand.Total() > dealerHand.Total()){
                Console.WriteLine("Player's {0} beats Dealer's {1}", playerHand.Total(), dealerHand.Total());
                Console.WriteLine("Player Wins!");
            }
            else{
                Console.WriteLine("Dealer's {1} beats Player's {0}", playerHand.Total(), dealerHand.Total());
                Console.WriteLine("Game Over!");
            }
        }
    }
}
