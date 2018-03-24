
using System;
using System.Collections.Generic;

namespace Superbowl
{
    public class NumToRoman
    {
   


        public string Ashley(int number)

        {
            //int parsedNumber = int.Parse(number);

            string[] romanNumerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        int[] decimals = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string romanNumber = string.Empty;

 

            for (int i = 0; i<romanNumerals.Length; i++)

            {

                while (number >= decimals[i])

                {

                    number -= decimals[i];

                    romanNumber += romanNumerals[i];
                    if (number == 0)
                    {
                        break;
                    }
                }
            }
            return romanNumber;
            //Console.WriteLine(romanNumber);

            //Console.ReadLine();

        }
      }





    //public class Number
    //    {
    //        public int NumberToConvert { get; set; }
    //    }
}