using System;
using System.Collections.Generic;
using System.Text;

namespace TestSuiteZone
{
    public class NumberToEnglish
    {
        public string MoneyConverter(int num)
        {
            if (num == 0)
            {
                return "zero";
            }
            if(num < 0)
            {
                return "minus " + MoneyConverter(Math.Abs(num));
            }

            string output = "";

            if ((num / 1000000) > 0)
            {
                output += MoneyConverter(num / 1000000) + " million ";
                num %= 1000000;
            }

            if ((num / 1000) > 0)
            {
                output += MoneyConverter(num / 1000) + " thousand ";
                num %= 1000;
            }

            if ((num / 100) > 0)
            {
                output += MoneyConverter(num / 100) + " hundred ";
                num %= 100;
            }

            if (num > 0)
            {
                if (output != "")
                {
                    output += "and ";
                }
            }

            string[] unit1 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] unit2 = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (num < 20)
            {
                output += unit1[num];
            }
            else
            {
                output += unit2[num / 10];
                if((num % 10) > 0)
                {
                    output += "-" + unit1[num % 10];
                }
            }
            
            return output;
        }
    }
}
