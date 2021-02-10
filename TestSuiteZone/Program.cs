using System;

namespace TestSuiteZone
{
    class Program
    {
        static void Main()
        {
            NumberToEnglish n = new NumberToEnglish();

            Console.WriteLine(n.MoneyConverter(1234));
        }
    }
}
