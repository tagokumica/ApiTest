using Application.Interface;

namespace Application.Validate.Spec
{
    public class HasCharNotNullSpec : ISpec
    {
        public bool IsValid(string password)
        {
            return !string.IsNullOrWhiteSpace(password); 
        }
    }
}