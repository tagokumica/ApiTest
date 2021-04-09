using System;

namespace Application.Interface
{
    public interface IUserValidate
    {
        bool IsValid(string password);
    }
}