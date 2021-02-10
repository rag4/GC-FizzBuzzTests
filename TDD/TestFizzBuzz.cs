using System;
using System.Collections.Generic;
using System.Text;
using TestSuiteZone;
using Xunit;


namespace TDD
{
    public class TestFizzBuzz
    {
        [Fact]
        public void TestEven()
        {
            FizzBuzz fb = new FizzBuzz();

            string actual = fb.OddEvenOrPrime(4);
            string expected = "even";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestOdd()
        {
            FizzBuzz fb = new FizzBuzz();

            string actual = fb.OddEvenOrPrime(9);
            string expected = "odd";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRange()
        {
            FizzBuzz fb = new FizzBuzz();

            string actual = fb.OddEvenOrPrime(0);
            string expected = "error";

            Assert.Equal(expected, actual);

            actual = fb.OddEvenOrPrime(101);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrime()
        {
            FizzBuzz fb = new FizzBuzz();

            bool actual = fb.CheckPrime(3);
            bool expected = true;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TestNotPrime()
        {
            FizzBuzz fb = new FizzBuzz();

            bool actual = fb.CheckPrime(4);
            bool expected = false;

            Assert.Equal(actual, expected);
        }

    }
}
