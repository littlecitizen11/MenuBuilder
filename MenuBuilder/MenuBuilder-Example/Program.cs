using System;
using System.Collections.Generic;
using MenuBuilder;

namespace MenuBuilder_Example
{
    class Program
    {
        public static void Check2()
        {
            Console.WriteLine("This is the end");

        }
        public static void Check1()
        {
            IMenuHandler mh = new MenuHandler();
            Action a = new Action(Check2);
            mh.RunIntMenu = new RunIntMenu();
            mh.RunIntMenu.Menu.AddOption(1, "Check2", a);
            mh.RunIntMenu.RunMenu();
        }
        static void Main(string[] args)
        {
            IMenuHandler mh = new MenuHandler();
            Action a = new Action(Check1);
            mh.RunIntMenu = new RunIntMenu();
            mh.RunIntMenu.Menu.AddOption(1, "Fuck", a);
            mh.RunIntMenu.RunMenu();
            

        }
    }
}
