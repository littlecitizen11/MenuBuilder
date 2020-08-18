using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class Sums : IAction<int>
    {
        public void Run(params int[] param)
        {
            int sum = 0;
            foreach (var item in param)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
    public class checkOption
    {
        public checkOption()
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            Sums sums = new Sums();
            Option<int> p = new Option<int>("blabla",sums);
        }
    }
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
