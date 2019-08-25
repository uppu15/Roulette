using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Result
    {

        public static int randomNumber()
        {
            int random;
            Random r = new Random();
            return random = r.Next(38);
        }

        public static void ResultTable()
        {
            Wheel wheel = new Wheel();
            Bin[] colorBoard = wheel.CreateWheelColor();
            Bin[] numberBoard = wheel.CreateWheelNumber();

            Console.WriteLine($"System rolled {randomNumber()}");
            Console.WriteLine($"You would have won if you bet on {numberBoard[randomNumber()].Number}");
        }

    }
}


