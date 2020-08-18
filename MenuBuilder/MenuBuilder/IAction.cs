using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IAction<T>
    {
        public void Run(params T[] param);
    }
}
