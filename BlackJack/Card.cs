namespace BlackJack {
    class Card {
        public int Value { get; }

        public Card(int value){
            this.Value = value;
        }

        public override string ToString(){
            return Value.ToString();
        }
    }
}
