using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestSuiteZone
{
    public class PasswordVerifier
    {
        public string Verify(string password)
        {
            int counter = 5;

            try
            {
                if (password.Length < 8)
                {
                    counter--;
                }
                if (password == null || password == "")
                {
                    counter--;
                }
                if (!password.Any(char.IsUpper))
                {
                    counter--;
                }
                if (!password.Any(char.IsLower))
                {
                    throw new Exception();
                }
                if (!password.Any(char.IsDigit))
                {
                    counter--;
                }
                if(counter < 3)
                {
                    throw new Exception();
                }
                
            }catch(Exception e)
            {
                return "INVALID password";
            }
            return "VALID password";

        }
    }
}
