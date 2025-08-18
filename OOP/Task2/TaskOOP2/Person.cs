using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOOP2.Company;

namespace TaskOOP2
{
    internal struct Person
    {
        public string Name;
        public string Age;

        public Person(string name, string age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
