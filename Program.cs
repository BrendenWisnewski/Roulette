using System;
//Worked together with John G. and Bradley. We refrenced a prior student, Cade Dillon
//on his implementation of building the roulette wheel using the two dimentional array.

namespace Roulette
{
    class Program
    {
       
        public static void Play()
        {
            Gamble gamble = new Gamble();
            int typeOfGamble = gamble.WhatKindOfBet();
            TheWheel wheel = new TheWheel();
            int[] ball = wheel.Spin();
            int whatColor = ball[0];
            int landed = wheel.Lands(ball);
            string color = wheel.RedOrBlack(whatColor).ToLower();
            Bets playerBet = new Bets();
           

            bool youWon;

            switch(typeOfGamble)
            {
                case 1:
                    youWon = playerBet.NumbersBet(landed);
                    if(youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else Console.WriteLine("OH Maybe Next Time!");
                    break;
                case 2:
                    youWon = playerBet.EvenOdd(landed);
                    if(youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else Console.WriteLine("OH Maybe Next Time!");
                    break;
                case 3:
                    youWon = playerBet.ColorLandedOn(color, landed);
                    if(youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else Console.WriteLine("OH Maybe Next Time!");
                    break;
                case 4:
                    youWon = playerBet.LowHigh(landed);
                    if(youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else
                    {
                        Console.WriteLine("OH Maybe Next Time!");
                    }
                    break;
                case 5:
                    youWon = playerBet.Dozens(landed);
                    if(youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else
                    {
                        Console.WriteLine("OH Maybe Next Time!");
                    }
                    break;
                case 6:
                    youWon = playerBet.Colums(landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else
                    {
                        Console.WriteLine("OH Maybe Next Time!");
                    }
                    break;
                case 7:
                    youWon = playerBet.Streets(landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else
                    {
                        Console.WriteLine("OH Maybe Next Time!");
                    }
                    break;
                    

            }



        }


        static void Main(string[] args)
        {
            bool keepPlaying = true;

            while(keepPlaying == true)
            {
                Play();

                Console.WriteLine("Play again? \nType yes or no");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes") keepPlaying = true;
                else keepPlaying = false;
                Console.Clear();

            }
           
            

        }
    }
}
