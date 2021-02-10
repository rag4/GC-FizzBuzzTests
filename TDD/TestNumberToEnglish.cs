using System;
using System.Collections.Generic;
using System.Text;
using TestSuiteZone;
using Xunit;

namespace TDD
{
    public class TestNumberToEnglish
    {
        [Fact]
        public void TestOnes()
        {
            NumberToEnglish n = new NumberToEnglish();

            string actual = n.MoneyConverter(1);
            string expected = "one";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTens()
        {
            NumberToEnglish n = new NumberToEnglish();

            string actual = n.MoneyConverter(23);
            string expected = "twenty-three";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestHundreds()
        {
            NumberToEnglish n = new NumberToEnglish();

            string actual = n.MoneyConverter(345);
            string expected = "three hundred and forty-five";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestThousands()
        {
            NumberToEnglish n = new NumberToEnglish();

            string actual = n.MoneyConverter(4567);
            string expected = "four thousand five hundred and sixty-seven";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTenThousands()
        {
            NumberToEnglish n = new NumberToEnglish();

            string actual = n.MoneyConverter(56789);
            string expected = "fifty-six thousand seven hundred and eighty-nine";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestHundredThousands()
        {
            NumberToEnglish n = new NumberToEnglish();

            string actual = n.MoneyConverter(678901);
            string expected = "six hundred and seventy-eight thousand nine hundred and one";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMillions()
        {
            NumberToEnglish n = new NumberToEnglish();

            string actual = n.MoneyConverter(7890123);
            string expected = "seven million eight hundred and ninety thousand one hundred and twenty-three";

            Assert.Equal(expected, actual);
        }

    }
}
