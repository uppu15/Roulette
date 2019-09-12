using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Result
    {

        public static void ResultTable()
        {
            Random r = new Random();
            int random = r.Next(38);

            Wheel wheel = new Wheel();
            Bin[] colorBoard = wheel.CreateWheelColor();
            Bin[] numberBoard = wheel.CreateWheelNumber();

            Console.WriteLine($"System rolled {random}");
            Console.WriteLine($"You would have won if you bet on {numberBoard[random].Number}");
            Console.WriteLine($"Color of {random} is {colorBoard[random].Color}");
            Console.WriteLine($"Even/Odd of {random} is {numberBoard[random].Even}");
            Console.WriteLine($"Column of {random} is {numberBoard[random].Column}");
            Console.WriteLine($"Row of {random} is {numberBoard[random].Row}");
            Console.WriteLine($"{random} is {numberBoard[random].FirstHalf}");
            Console.WriteLine($"{random} is {numberBoard[random].Dozen} dozen");
        }

    }
}


