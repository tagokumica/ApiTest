using System.Text.RegularExpressions;
using Application.Interface;

namespace Application.Validate.Spec
{
    public class RepeatedCharacterSpec: ISpec
    {
        public bool IsValid(string password)
        {
            var repeatedCharacter = new Regex(@"(.)\1+");

            return !repeatedCharacter.IsMatch(password);
        }
    }
}