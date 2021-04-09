using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Application.Interface;

namespace Application.Validate
{
    public class UserValidate: IUserValidate
    {

        private List<ISpec> _Specs;

        public UserValidate(List<ISpec> specs)
        {
            _Specs = specs;
        }

        

        public bool IsValid(string password)
        {
            foreach (var spec in _Specs)
            {
                if (!spec.IsValid(password))
                {
                    return false;
                }
            }

            return true;
        }
    }
}