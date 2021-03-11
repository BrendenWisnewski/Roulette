using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class TheWheel
    {
        //first array red, second array is black, including 0 in red and 00 in black for now
        public int[,] rouletteWheel =
        {
            {1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 24, 36, 0 }, //Red numbers
            {2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35, 00 } //black numbers
        };

        //create a method to create an array to locate the pocket of the ball

        public int[] Spin()
        {
            Random ball = new Random();

            int color = ball.Next(0, 2); //chooses the first or second array which is red or black
            int number = ball.Next(0, 19); //which number out of each color array

            int[] ballLocation = { color, number }; //array showing the color and number of the ball;

            return ballLocation;          
        }
        public int Lands(int[] ballLocation)
        {
            int color = ballLocation[0];
            int number = ballLocation[1];

            int landed = rouletteWheel[color, number];
            return landed;
        }

        public string RedOrBlack(int color)
        {
            if (color == 0) return "red";
            else return "black";
        }
       
    }
}
