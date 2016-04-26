using System.Collections;
namespace BlackJack {
    class Hand {
        ArrayList cards;
        public Hand() {
            cards = new ArrayList();
        }

        public void AddCard(Card card){
            cards.Add(card);
        }

        public bool IsBusted(){
            return this.Total() > 21;
        }

        public int Total(){
            int total = 0;
            foreach(Card card in cards){
                total += card.Value;
            }
            return total;
        }
        public override string ToString() {
            string s = "Hand: ";
            foreach(Card card in cards){
                s += card + " ";
            }
            s += "\nTotal: ";
            s += Total();
            return s;
        }
    }
}
