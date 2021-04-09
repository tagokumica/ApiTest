using System.Text.RegularExpressions;
using Application.Interface;

namespace Application.Validate.Spec
{
    public class HasMinMaxCharsSpec : ISpec
    {
        public bool IsValid(string password)
        {
            var hasMiniMaxChars = new Regex(@".{9,15}");

            return hasMiniMaxChars.IsMatch(password);
        }
    }
}