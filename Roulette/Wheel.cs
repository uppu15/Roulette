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

        public string FirstHalf { get; set; }
        public string Even { get; set; }
        public string Color { get; set; }
        public string Dozen { get; set; }
        public int Number { get; set; }
        public string Column { get; set; }
        public int Row { get; set; }
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
                if (i > 0 && i < 19) binNumber[i].FirstHalf = "Upper half";
                else if (i > 18 && i <= 38) binNumber[i].FirstHalf = "Lower half";
                
                
                //assign if box is first, second or third dozen
                if (i > 0 && i < 13) binNumber[i].Dozen = "first";
                else if (i > 12 && i < 25) binNumber[i].Dozen = "second";
                else if (i > 24 && i < 37) binNumber[i].Dozen = "third";

                //assign what street a box is in
                if (i > 0 && i % 3 == 1) binNumber[i].Column = "left";
                else if (i > 0 && i % 3 == 2) binNumber[i].Column = "middle";
                else if (i > 0 && i % 3 == 0) binNumber[i].Column = "right";

                //assign colors to box and determine if is even number.
                if (i < 37 && i > 0 && i % 2 == 0)
                {
                    binNumber[i].Even = "even";
                }
                else if (i < 37 && i % 2 == 1)
                {
                    binNumber[i].Even = "odd";
                }
                else
                {
                    binNumber[i].Even = "even";
                }

                //assign rows to box
                if (i / 3 == 0)
                {
                    binNumber[i + 1].Row = 1;
                }else if (i / 3 == 1)
                {
                    binNumber[i + 1].Row = 2;
                }else if (i / 3 == 2)
                {
                    binNumber[i + 1].Row = 3;
                }else if (i / 3 == 3)
                {
                    binNumber[i + 1].Row = 4;
                }else if (i / 3 == 4)
                {
                    binNumber[i + 1].Row = 5;
                }else if (i / 3 == 5)
                {
                    binNumber[i + 1].Row = 6;
                }else if (i / 3 == 6)
                {
                    binNumber[i + 1].Row = 7;
                }else if (i / 3 == 7)
                {
                    binNumber[i + 1].Row = 8;
                }else if (i / 3 == 8)
                {
                    binNumber[i + 1].Row = 9;
                }else if (i / 3 == 9)
                {
                    binNumber[i + 1].Row = 10;
                }else if (i / 3 == 10)
                {
                    binNumber[i + 1].Row = 11;
                }else if (i / 3 == 11)
                {
                    binNumber[i + 1].Row = 12;
                }else if (i == 0 || i == 37)
                {
                    binNumber[i].Row = 0;
                }
            }

            binColor = new Bin[38];
            for (int i = 0; i < binColor.Length; i++)
            {
                binColor[i] = new Bin();
            }
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