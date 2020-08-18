using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class RunIntMenu
    {

        public Menu<int> Menu { get; set; }
        public IValidNum<int> Validator { get; set; }
        public RunIntMenu()
        {
            Menu = new Menu<int>();
            Validator = new Validations<int>();
        }

        public void RunMenu()
        {
            int num = -1;
            Console.WriteLine("Click 0 to exit");
            while (num != 0)
            {
                foreach (var item in Menu.Dict)
                {
                    Console.WriteLine("{" + item.Key + "} Value : " + item.Value.Description);

                }
                string input = Console.ReadLine();
                if (Validator.IsValidNum(input))
                {
                    num = int.Parse(input);
                    Menu.SelectOption(num);
                }
                else num = -1;
            }
        }
    }
}
