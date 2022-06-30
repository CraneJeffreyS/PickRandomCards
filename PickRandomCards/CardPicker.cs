using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuite();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            switch (value)
            {
                case 1: return "Ace";
                case 10: return "Jack";
                case 11: return "Queen";
                case 12: return "King";
                default: return value.ToString();
            }
        }

        private static string RandomSuite()
        {
            int value = random.Next(1, 5);
            switch (value)
            {
                case 1: return "Spades";
                case 2: return "Diamonds";
                case 3: return "Hearts";
                default: return "Clubs";
            }
        }
    }
}
