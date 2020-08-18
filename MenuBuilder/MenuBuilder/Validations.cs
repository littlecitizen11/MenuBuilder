using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MenuBuilder
{
    public abstract class Validations<P>
    {
        public Validations() {}

        public void IsValid(object a)
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

        public void IsNull(object a)
        {
            if (a is null)
                throw new ArgumentNullException();

        }
        public void CheckType(object a)
        {
            if (!(typeof(P) == a.GetType()))
                throw new TypeLoadException();

        }

    }
}
