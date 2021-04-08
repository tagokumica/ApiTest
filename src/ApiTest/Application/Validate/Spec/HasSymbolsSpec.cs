using System.Text.RegularExpressions;
using Application.Interface;

namespace Application.Validate.Spec
{
    public class HasSymbolsSpec : ISpec
    {
        public bool IsValid(string password)
        {
            var hasSymbols = new Regex(@"[!@#$%^&*()+-]");

            return !hasSymbols.IsMatch(password);
        }
    }
}