using System;
using System.Collections.Generic;
using System.Text;

namespace Notes___Classes_and_Structs
{
    public class Person
    {

        //public string Name { get; } /* a readonly proerty

        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor that takes no argument
        public Person()
        {
            Name = "unknown";
        }

        // Construtor that takes one argument
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }

        // Other properties, methods, events...
    }

    public struct PersonStruct
    {
        public string Name;
        public int Age;
        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
