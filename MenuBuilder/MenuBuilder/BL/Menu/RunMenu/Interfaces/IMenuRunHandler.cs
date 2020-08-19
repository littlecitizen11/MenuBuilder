using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IMenuRunHandler<T>
    {
        public IRunMenu<T> RunMenu { get; set; }

    }
}
