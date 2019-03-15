using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Employee
    {
        string _name;
        string _lastname;
        int _age;

        public string Name;
        public string LastName;
        public int Age;

        public override string ToString()
        {
            string empl = $"{Name} {LastName} {Age}";

            return empl;
        }
    }
}
