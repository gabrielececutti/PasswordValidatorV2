using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaswordValidatorConsoleApp
{
    public abstract class PasswordDecoratorValidator : IPasswordValidator
    {
        public abstract string GetErrors();
        public abstract bool IsValid();
    }
}
