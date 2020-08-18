using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class Option
    {
        public string Description { get; set; }
        public Action RunFunc { get; set; }
        public Option(string description, Action action)
        {
            Description = description;
            RunFunc = action;
        }
    }
}
