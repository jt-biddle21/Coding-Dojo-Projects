using System;
using Cards;
using Decks;
using System.Collections.Generic;

namespace Dealers
{
    public class Dealer
    {
        public string name;
        private List<Card> mycards;

        public Dealer(string first) {
            mycards = new List<Card>();
            name = first;
        }

        public void DrawFrom(Deck currentDeck) {
            mycards.Add(currentDeck.Deal());
        }
        
        public Card Discard(int i) {
            Card temp = mycards[i];
            mycards.RemoveAt(i);
            return temp;
        }
        public override string ToString() {
            return ">>>Your dealer is: " + name;
        }
    }
}
