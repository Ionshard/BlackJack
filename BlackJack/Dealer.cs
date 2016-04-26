using System;
namespace BlackJack {
    class Dealer : Player {
        public Dealer() : base() {}

        public override Hand Deal(Deck deck){
            while(hand.Total() < 17){
                DealCards(1, deck);
            }
            return hand;
        }
    }
}
