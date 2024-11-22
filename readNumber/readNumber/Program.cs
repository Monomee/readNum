using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace readNumber
{
    internal class Program
    {
        static string oneDigit(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return null;
            }
        }

        static string twoDigits(int digit)
        {
            int units = digit % 10;
            int tens = digit / 10;
            string nums = "";
            switch (tens)
            {
                case 1:
                    switch (units)
                    {
                        case 0:
                            nums += "ten";
                            break;
                        case 1:
                            nums += "eleven";
                            break;
                        case 2:
                            nums += "twelve";
                            break;
                        case 3:
                            nums += "thirteen";
                            break;
                        case 5:
                            nums += "fifteen";
                            break;
                        default:
                            nums += oneDigit(units) + "teen";
                            break;
                    }
                    break;
                case 2:
                    nums += (units == 0) ? "twenty" : ("twenty " + oneDigit(units));
                    break;
                case 3:
                    nums += (units == 0) ? "thirty" : ("thirty " + oneDigit(units));
                    break;
                case 4:
                    nums += (units == 0) ? "forty" : ("forty " + oneDigit(units));
                    break;
                case 5:
                    nums += (units == 0) ? "fifty" : ("fifty " + oneDigit(units));
                    break;
                default:
                    nums += (units == 0) ? (oneDigit(tens) + "ty") : (oneDigit(tens) + "ty " + oneDigit(units));
                    break;
            }

            return nums;
        }

        static string threeDigits(int digit)
        {
            int hundreds = digit / 100;
            int remain = digit % 100;
            return oneDigit(hundreds) + " hundred and " + twoDigits(remain);
        }

        static void Main(string[] args)
        {
            bool condition = true;
            Console.WriteLine("Enter the number:");
            do
            {                
                string input = Console.ReadLine();
                condition = !(int.TryParse(input, out int nums));
                if (condition)
                {
                    Console.WriteLine("Re-enter please!");
                }
                if (!condition)
                {
                    int length = nums.ToString().Length;
                    if (nums < 0)
                    {
                        Console.WriteLine("Not supported");
                        continue;
                    }
                    switch (length)
                    {   
                        case 1:
                            Console.WriteLine(oneDigit(nums));
                            break;
                        case 2:
                            Console.WriteLine(twoDigits(nums));
                            break;
                        case 3:
                            Console.WriteLine(threeDigits(nums));
                            break;
                        default:
                            Console.WriteLine("out of ability");
                            break;
                    }
                }
            } while (condition);

            Console.ReadLine();
        }
    }
}
