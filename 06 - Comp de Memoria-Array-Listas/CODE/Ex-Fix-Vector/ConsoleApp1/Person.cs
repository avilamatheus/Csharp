using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
