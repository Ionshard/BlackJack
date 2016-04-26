using System;

namespace BlackJack {
    class MainClass {
        public static void Main (string[] args) {
            Console.WriteLine ("Welcome to C# BlackJack");
            Game game = new Game();
            game.Play();
        }
    }
}
