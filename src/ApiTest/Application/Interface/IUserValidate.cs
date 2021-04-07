using System;

namespace Application.Interface
{
    public interface IUserValidate: IDisposable
    {
        bool IsValid(string password);
    }
}