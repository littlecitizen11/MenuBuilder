using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IRunMenu<P>
    {
        public Menu<P> Menu { get; set; }
        public IValidations<P> Validator { get; set; }
        public void Run();

    }
}
