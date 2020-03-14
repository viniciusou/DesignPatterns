﻿using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    public class UserFlyWeight
    {
        static List<string> strings = new List<string>();
        private int[] names;

        public UserFlyWeight(string fullName)
        {
            int getOrAdd(string s)
            {
                int idx = strings.IndexOf(s);
                if (idx != -1)
                {
                    return idx;
                } 
                else
                {
                    strings.Add(s);
                    return strings.Count - 1;
                }
            }

            names = fullName.Split(' ').Select(getOrAdd).ToArray();
        }

        public string FullName => string.Join(" ", names.Select(i => strings[i]).ToArray());
    }
}
