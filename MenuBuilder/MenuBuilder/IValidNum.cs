using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IValidNum<T>:IValidations<T>
    {
        public bool IsValidNum(string input);
    }
}
