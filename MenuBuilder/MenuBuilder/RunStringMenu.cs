using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class RunStringMenu
    {

        public Menu<string> Menu { get; set; }
        public IValidations<string> Validator { get; set; }
        public RunStringMenu()
        {
            Menu = new Menu<string>();
            Validator = new Validations<string>();
        }

        public void RunMenu()
        {
            string str = "o";
            Console.WriteLine("Click o to exit");
                        while (str != "close")
            {
                foreach (var item in Menu.Dict)
                {
                    Console.WriteLine("{" + item.Key + "} Value : " + item.Value.Description);

                }
                string input = Console.ReadLine();
                Validator.IsValid(input);
                Menu.SelectOption(str);
                 str = "o";
            }
        }
    }
}
