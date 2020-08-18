using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IMenuHandler
    {
        public RunIntMenu RunIntMenu { get; set; }
        public RunStringMenu RunStringMenu { get; set; }

    }
}
