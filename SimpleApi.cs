namespace FilterAPi
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public enum Types_class : int {
        Russian,
        Engilsh
    }
    public struct cab
    {
        public Types_class type;
        public int number;
    }
    public class MainClass
    { 
        public List<cab> cabs = new List<cab>();
        public void add(int num, Types_class type) {
            cab c;
            c.type = type;
            c.number = num;
            cabs.Add(c); 
        }

        public List<cab> filter(Types_class type)
        {
            List<cab> a = new List<cab>();
            foreach(cab i in cabs)
            {
                if (i.type == type)
                {
                    a.Add(i);
                }
            }
            return a;
        }
    }
}
