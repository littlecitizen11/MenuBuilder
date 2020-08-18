using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MenuBuilder
{
    public class Validations<P> : IValidations<P>, IValidNum<P>
    {
        public Validations() {}

        public void IsValid(P a)
        {
            try
            {
                IsNull(a);
                CheckType(a);
            }
            catch (Exception e)
            {

                Console.WriteLine("{0} Exception caught",e.Message);
            }
        }

        public void IsNull(P a)
        {
            if (a is null)
                throw new ArgumentNullException();

        }
        public void CheckType(P a)
        {
            if (!(typeof(P) == a.GetType()))
                throw new TypeLoadException();

        }

        public bool IsValidNum(string input)
        {
            int a;
            try {
                if (!int.TryParse(input, out a))
                    throw new InvalidCastException();
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught", e.Message);
                return false;
            }
            return true;

        }
    }
}
