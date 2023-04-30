using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaswordValidatorConsoleApp
{
    public interface IPasswordValidator
    {
        public  string GetErrors();
        public bool IsValid();
    }
}
