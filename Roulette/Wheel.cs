using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Bin
    {
        static bool[] upDown;
        static bool[] isEven;
        static string[] color;
        static int[] dozen;
        static int[] number;
        static string[] column;

        public bool FirstHalf { get; set; }
        public bool Even { get; set; }
        public string Color { get; set; }
        public int Dozen { get; set; }
        public int Number { get; set; }
        public string Column { get; set; }
    }

    public class Wheel
    {
        Bin[] binNumber;
        Bin[] binColor;

        public Wheel()
        {

            binNumber = new Bin[38];
            for (int n = 0; n < binNumber.Length; n++)
            {
                binNumber[n] = new Bin();
                //binColor[n] = new Bin();
            }
            for (int i = 0; i < binNumber.Length; i++)
            {
                //assign numbers to bin
                binNumber[i].Number = i;
                binNumber[37].Number = 00;

                //assign if box is lower half or upper half
                if (i > 0 && i < 19) binNumber[i].FirstHalf = true;
                else if (i > 18 && i <= 38) binNumber[i].FirstHalf = false;

                //assign if box is first, second or third dozen
                if (i > 0 && i < 13) binNumber[i].Dozen = 1;
                else if (i > 12 && i < 25) binNumber[i].Dozen = 2;
                else if (i > 24 && i < 37) binNumber[i].Dozen = 3;

                //assign what street a box is in
                if (i > 0 && i % 3 == 1) binNumber[i].Column = "left";
                else if (i > 0 && i % 3 == 2) binNumber[i].Column = "middle";
                else if (i > 0 && i % 3 == 0) binNumber[i].Column = "right";

                //assign colors to box and determine if is even number.
                if (i < 37 && i > 0 && i % 2 == 0)
                {
                    binNumber[i].Even = true;
                }
                else if (i < 37 && i % 2 == 1)
                {
                    binNumber[i].Even = false;
                }
            }

            binColor = new Bin[38];
            //assign color to box
            for (int i = 0; i < binColor.Length; i++)
            {
                if (i < 10)
                {
                    if (i % 2 == 1)
                    {
                        binColor[i].Color = "red";
                    }
                    else
                    {
                        binColor[i].Color = "black";
                    }
                }
                if (i < 19 && i > 10)
                {
                    if (i % 2 == 0)
                    {
                        binColor[i].Color = "red";
                    }
                    else
                    {
                        binColor[i].Color = "black";
                    }
                }
                if (i < 29 && i > 18)
                {
                    if (i % 2 == 1)
                    {
                        binColor[i].Color = "red";
                    }
                    else
                    {
                        binColor[i].Color = "black";
                    }
                }
                if (i < 37 && i > 28)
                {
                    if (i % 2 == 0)
                    {
                        binColor[i].Color = "red";
                    }
                    else
                    {
                        binColor[i].Color = "black";
                    }
                }
                binColor[0].Color = "green";
                binColor[37].Color = "green";
            }

        }

        public Bin[] CreateWheelNumber()
        {
            return binNumber;
        }

        public Bin[] CreateWheelColor()
        {
            return binColor;
        }

    }
}