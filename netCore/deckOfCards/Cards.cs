using System;

namespace Cards
{
    public class Card
    {
        public string stringval;
        public string suit;
        public int val;
        public Card(string suittype, int cardval)
        {
            if (cardval == 1)
            {
                stringval = "Ace";
            }
            else if (cardval == 11) 
            {
                stringval = "Jack";
            }
            else if (cardval == 12)
                {
                stringval =  "Queen";
            }
            else if (cardval == 13) 
            {
                stringval =  "King";
            }
            else if(cardval > 1 && cardval < 11){
                stringval = cardval.ToString();
            }
            else{
                stringval = "Joker";
            }
            val = cardval;
            suit = suittype;
        }
        public override string ToString() {
            return "|<>|>< " + stringval + " of " + suit + " ><|<>|";
        }
    }
}
