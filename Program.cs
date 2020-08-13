using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumberGenerator = new Random();

            var ranks = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            var cards = new List<string>() { };

            foreach (var rank in ranks)
            {
                foreach (var suit in suits)
                {

                    cards.Add(rank + " of " + suit);
                }
            }


            // var n = cards.Count();





            for (var index = cards.Count() - 1; index >= 0; index--)
            {


                var randomNumber = randomNumberGenerator.Next(52);

                var swapCards = cards[index];
                cards[index] = cards[randomNumber];
                cards[randomNumber] = swapCards;





            };
            Console.WriteLine(cards[0]);
            Console.WriteLine(cards[1]);



        }
    }
}
