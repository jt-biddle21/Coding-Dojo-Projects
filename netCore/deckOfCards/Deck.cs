using System;
using Cards;
using System.Collections.Generic;

namespace Decks
{
    public class Deck
    {
        public List<Card> cards;
        public Deck ResetDeck()
        {
            cards = new List<Card>();
            string[] suits = {"Hearts", "Diamonds", "Spades", "Clubs"};
            string[] cardvals = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            for (int suit = 0; suit < suits.Length; suit++)
            {
                for (int val = 0; val < cardvals.Length; val++)
                {
                    cards.Add(new Card(suits[suit], val+1));
                }
            }
            return this;
        }
        public Deck Shuffle() {
            Random rand = new Random();
            for(int i = cards.Count - 1; i > 0; i--) {
                int randcard = rand.Next(i);
                Card temp = cards[randcard];
                cards[randcard] = cards[i];
                cards[i] = temp;
            }
            return this;
        }
        public Deck()
        {
            ResetDeck();
        }
         public Card Deal()
        {
            if (cards.Count > 0)
            {
                Card temp = cards[0];
                cards.RemoveAt(0);
                return temp;   
            }
            return null;
        }
        public override string ToString() {
            string info = "";
            foreach(Card card in cards) {
                info += card + "\n";
            }
            return info;
        }
    }
}
