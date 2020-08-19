using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class Menu<P>
    {
        public Dictionary<P, Option> Dict { get; set; }
        public IValidations<P> Vali { get; set; }
        public Menu()
        {
            Vali = new Validations<P>();
            Dict = new Dictionary<P, Option>();
            
        }
        public void AddOption(P key, string description, Action action)
        {
            if (IsKeyInDict(key)&&!Vali.IsValid(key))
            {
                return;
            }
            Dict.Add(key, new Option(description, action));
        }
        public Dictionary<P,Option> GetDict()
        {
            return Dict;
        }
        public bool IsKeyInDict(P key)
        {
            try
            {
                if (!((Dict.Select(x=>x).Where(x=>x.Key.Equals(key)).Count())>0)&&(Dict.Count>0)) throw new KeyNotFoundException();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caugt",e.Message);
                return false;
            }
            return true;
        }
        public Option GetDictByKey(P key)
        {
                if (IsKeyInDict(key) && Vali.IsValid(key))
                {
                    return Dict[key];
                }
            return null;
        }
        public void SelectOption(P key)
        {   
            var dict = GetDictByKey(key);
            if (!(dict is null))
            {
                dict.RunFunc();
            }
        }
        


    }
}
