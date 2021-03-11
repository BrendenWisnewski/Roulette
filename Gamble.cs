using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
   public  class Gamble
    {
        public int WhatKindOfBet()
        {
            Console.WriteLine("Choose what kind of bet you would like to do:");
            Console.WriteLine("1. Bet a number");
            Console.WriteLine("2. Even or Odd, pick if the number will be even or odd.");
            Console.WriteLine("3. Red or Black, pick if the color is black or red.");
            Console.WriteLine("4. Low(1-18) or High(19-36)");
            Console.WriteLine("5. Gamble on the Dozens");
            Console.WriteLine("6. Bet that the ball will land in a column 1,2, or 3.");
            Console.WriteLine("7. Bet on a street 1/2/3 for example");

            int playerBet = Int32.Parse(Console.ReadLine());

            return playerBet;
        }
    }
}
