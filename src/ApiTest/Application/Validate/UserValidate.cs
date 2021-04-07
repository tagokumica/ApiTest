using System;
using System.Text.RegularExpressions;
using Application.Interface;

namespace Application.Validate
{
    public class UserValidate: IUserValidate
    {

      

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool IsValid(string password)
        {
            var input = password;

            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{9,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()+-]");
            var repeatedCharacter = new Regex(@"(\w)*.*\1");
            if (!hasLowerChar.IsMatch(input))
            {
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                return false;
            }
            else if (!repeatedCharacter.IsMatch(input))
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}