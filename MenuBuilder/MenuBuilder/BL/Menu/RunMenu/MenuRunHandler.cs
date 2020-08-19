using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;

namespace MenuBuilder
{
    public class MenuRunHandler<T>: IMenuRunHandler<T>
    {
        public IRunMenu<T> RunMenu { get; set; }

        public MenuRunHandler()
        {

        }
        
    }
}
