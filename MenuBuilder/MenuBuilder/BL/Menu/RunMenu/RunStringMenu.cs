using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class RunStringMenu : IRunMenu<string>
    {

        public Menu<string> Menu { get; set; }
        public IValidations<string> Validator { get; set; }
        public RunStringMenu()
        {
            Menu = new Menu<string>();
            Validator = new Validations<string>();
        }

        public void Run()
        {
            string input =null;
            Console.WriteLine("Click close to exit");
            while (input != "close")
            {
                foreach (var item in Menu.Dict)
                {
                    Console.WriteLine("{" + item.Key + "} Value : " + item.Value.Description);

                }
                input = Console.ReadLine();
                if(Validator.IsValid(input))
                    Menu.SelectOption(input);
                else input = null;
            }
        }
    }
}
