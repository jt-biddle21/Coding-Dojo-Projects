using System;
using Cards;
using Decks;
using Dealers;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            Dealer dealer1 = new Dealer("Justin");
            Console.WriteLine(deck1);
            Console.WriteLine(dealer1);
        }
    }
}
