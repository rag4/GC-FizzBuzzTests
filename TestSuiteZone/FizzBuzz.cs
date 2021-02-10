using System;
using System.Collections.Generic;
using System.Text;

namespace TestSuiteZone
{
    public class FizzBuzz
    {
        public string OddEvenOrPrime(int num)
        {
            if (num > 0 && num <= 100)
            {
                if (num % 2 == 0)
                {
                    return "even";
                }
                else
                {
                    return "odd";
                }
            }
            else
            {
                return "error";
            }
        }

        public bool CheckPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
