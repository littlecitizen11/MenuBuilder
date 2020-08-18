using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;

namespace MenuBuilder
{
    public class MenuHandler:IMenuHandler
    {
        public RunIntMenu RunIntMenu { get; set; }
        public RunStringMenu RunStringMenu { get; set; }

        public MenuHandler()
        {

        }
        
    }
}
