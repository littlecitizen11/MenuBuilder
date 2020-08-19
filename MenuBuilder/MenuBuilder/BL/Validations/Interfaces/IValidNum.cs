using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IValidNum<T>
    {
        public bool IsValidNum(string input);
    }
}
