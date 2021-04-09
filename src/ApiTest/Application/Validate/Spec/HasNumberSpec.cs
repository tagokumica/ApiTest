using System.Text.RegularExpressions;
using Application.Interface;

namespace Application.Validate.Spec
{
    public class HasNumberSpec : ISpec
    {
        public bool IsValid(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");

            return hasNumber.IsMatch(password);
        }
    }
}