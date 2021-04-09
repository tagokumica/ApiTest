using System.Text.RegularExpressions;
using Application.Interface;

namespace Application.Validate.Spec
{
    public class HasLowerCharSpec : ISpec
    {
        public bool IsValid(string password)
        {
            var hasLowerChar = new Regex(@"[a-z]+");

            return hasLowerChar.IsMatch(password);
        }
    }
}