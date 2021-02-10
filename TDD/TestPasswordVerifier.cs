using System;
using System.Collections.Generic;
using System.Text;
using TestSuiteZone;
using Xunit;

namespace TDD
{
    public class TestPasswordVerifier
    {
        [Fact]
        public void TestStrongOK()
        {
            PasswordVerifier p = new PasswordVerifier();

            string actual = p.Verify("coreGame1");
            string expected = "VALID password";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestWeakOK()
        {
            PasswordVerifier p = new PasswordVerifier();

            string actual = p.Verify("coregame");
            string expected = "VALID password";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestWeakBAD1()
        {
            PasswordVerifier p = new PasswordVerifier();

            string actual = p.Verify("COREGAME");
            string expected = "INVALID password";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestWeakBAD2()
        {
            PasswordVerifier p = new PasswordVerifier();

            string actual = p.Verify("c");
            string expected = "INVALID password";

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("coRAm3")]
        [InlineData("coregam3")]
        [InlineData("coregame")]
        [InlineData("1ca")]
        public void TestGoodMultiple(string password)
        {
            PasswordVerifier p = new PasswordVerifier();
            string actual = p.Verify(password);
            string expected = "VALID password";

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData("CORE")]
        [InlineData("")]
        [InlineData("core")]
        [InlineData("60431234")]
        public void TestBadMultiple(string password)
        {
            PasswordVerifier p = new PasswordVerifier();
            string actual = p.Verify(password);
            string expected = "INVALID password";

            Assert.Equal(expected, actual);

        }
    }
}
