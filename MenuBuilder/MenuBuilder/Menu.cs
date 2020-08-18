using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class Menu<P,T> : Validations<P>
    {
        public Dictionary<P, Option<T>> Dict { get; set; }
        public Validations<P> Vali { get; set; }
        public Menu()
        {
            Dict = new Dictionary<P, Option<T>>();
        }
        public void AddOption(P key, string description, IAction<T> action)
        {
            Vali.IsValid(key);
            if (IsKeyInDict(key))
            {
                return;
            }
            Dict.Add(key, new Option<T>(description, action));
        }
        public Dictionary<P,Option<T>> GetDict()
        {
            return Dict;
        }
        public bool IsKeyInDict(P key)
        {
            Vali.IsValid(key);
            try
            {
                if (!Dict.ContainsKey(key)) throw new KeyNotFoundException();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caugt" +e.Message);
                return false;
            }
            return Dict.ContainsKey(key);
        }
        public Dictionary<P,Option<T>> GetDictByKey(P key)
        {
                if (IsKeyInDict(key))
                {
                    var d = (Dictionary<P, Option<T>>)Dict.Where(t => t.Key.Equals(key)).Select(t => t);
                    return d;
                }
            return null;
        }
        public void SelectOption(P key)
        {
            
            var dict = GetDictByKey(key);
            if (!(dict is null))
            {   var d = Dict.Select(t => t.Value.RunFunc);
                foreach (var item in d)
                {
                    item.Run();
                }
            }
        }


    }
}
