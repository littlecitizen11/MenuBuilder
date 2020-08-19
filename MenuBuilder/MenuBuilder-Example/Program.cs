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
            IMenuHandler<string> mh = new MenuHandler<string>();
            Action a = new Action(Check2);
            mh.RunMenu = new RunStringMenu();
            mh.RunMenu.Menu.AddOption("This is a key", "Check2", a);
            mh.RunMenu.Run();
        }
        static void Main(string[] args)
        {
            IMenuHandler<int> mh = new MenuHandler<int>();
            Action a = new Action(Check1);
            mh.RunMenu = new RunIntMenu();
            mh.RunMenu.Menu.AddOption(1, "Check1", a);
            mh.RunMenu.Run();
            

        }
    }
}
