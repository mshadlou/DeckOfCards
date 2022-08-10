using System;
namespace DeckOfCards
{
    public enum Faces
    {
        Ace = 0, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    public enum Names
    {
        Diamonds = 0, Clubs, Hearts, Spades
    }

    class Program
    {
        public static void Main()
        {
            Deck d = new Deck();

            // --------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" //////////////// Show the deck ///////////////////");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Card i in d.deck)
            {
                Console.WriteLine(i);
            }
            // --------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" //////////////// Shuffle the deck ///////////////////");
            Console.ForegroundColor = ConsoleColor.White;
            d.Shuffle();
            
            foreach(Card i in d.deck)
            {
                Console.WriteLine(i);
            }
            // --------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" //////////////// Sort the deck ///////////////////");
            Console.ForegroundColor = ConsoleColor.White;
            d.Sort();
            foreach (Card i in d.deck)
            {
                Console.WriteLine(i);
            }
            // --------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" //////////////// Deal the top card from the deck ///////////////////");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(d.DealTopCard());
            // --------------------------------------------------------------------------------

            Console.ReadLine();
        }
    }

}
