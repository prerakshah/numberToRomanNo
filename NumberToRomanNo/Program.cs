using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToRomanNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jay Shree Krushna");
            int number = Convert.ToInt32(Console.ReadLine());
            string romanNo = numberToRoman(number);
            Console.WriteLine("Roman Number is : {0} ", romanNo);
            Console.ReadKey();
        }

        public static string numberToRoman(int number)
        {
            string romanNo = "";

            while (number > 0)
            {
                if (number >= 1000)
                {
                    romanNo += "M";
                    number -= 1000;
                    continue;
                }
                if (number >= 900)
                {
                    romanNo += "CM";
                    number -= 900;
                    continue;
                }
                if (number >= 500)
                {
                    romanNo += "D";
                    number -= 500;
                    continue;
                }
                if (number >= 400)
                {
                    romanNo += "CD";
                    number -= 400;
                    continue;
                }
                if (number >= 100)
                {
                    romanNo += "C";
                    number -= 100;
                    continue;
                }
                if (number >= 90)
                {
                    romanNo += "XC";
                    number -= 90;
                    continue;
                }
                if (number >= 50)
                {
                    romanNo += "L";
                    number -= 50;
                    continue;
                }
                if (number >= 40)
                {
                    romanNo += "XL";
                    number -= 40;
                    continue;
                }
                if (number >= 10)
                {
                    romanNo += "X";
                    number -= 10;
                    continue;
                }
                if (number == 9)
                {
                    romanNo += "IX";
                    number -= 9;
                    continue;
                }
                if (number >= 5 && number <= 8)
                {
                    romanNo += "V";
                    number -= 5;
                    continue;
                }
                if (number == 4)
                {
                    romanNo += "IV";
                    number -= 4;
                    continue;
                }
                if (number >= 1 && number <= 3)
                {
                    romanNo += "I";
                    number -= 1;
                    continue;
                }
            }

            return romanNo;
        }
    }
}
