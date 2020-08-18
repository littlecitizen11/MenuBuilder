using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class Option<T>
    {
        public string Description { get; set; }
        public IAction<T> RunFunc { get; set; }
        public Option(string description, IAction<T> action)
        {
            Description = description;
            RunFunc = action;
        }
    }
}
