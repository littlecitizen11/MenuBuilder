using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MenuBuilder
{
    public interface IValidations<P>
    {
        public bool IsValid(P a);
        public void IsNull(P a);
        public void CheckType(P a);
        public bool IsValidNum(string input);

    }
}
