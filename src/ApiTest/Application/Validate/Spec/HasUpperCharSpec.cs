using System.Text.RegularExpressions;
using Application.Interface;

namespace Application.Validate.Spec
{
    public class HasUpperCharSpec : ISpec
    {
        public bool IsValid(string password)
        {
            var hasUpperChar = new Regex(@"[A-Z]+");

            return hasUpperChar.IsMatch(password);
        }
    }
}