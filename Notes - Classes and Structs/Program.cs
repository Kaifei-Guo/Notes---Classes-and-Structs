using System;
using System.Dynamic;

namespace Notes___Classes_and_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type CustomClass
            CustomClass custClass = new CustomClass();

            // Set the value of the public property
            custClass.Number = 27;

            // Call the public method
            int result = custClass.Multiply(4);
            Console.WriteLine($"The result is {result}.");
            PrintDivider();

            // Create a Person object and call the constructor that has no parameters. 
            Person person1 = new Person();
            Console.WriteLine(person1.Name);
            PrintDivider();

            // Create a Person object and call the constructor that has one parameter. 
            Person person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            PrintDivider();

            // Get the string representation of the person2 instance.
            Console.WriteLine(person2.ToString());
            PrintDivider();

            // Create more Persons objects
            Person person3 = new Person("Leopold", 6);
            Console.WriteLine($"Person 3 Name: {person3.Name}, age: {person3.Age}");
            // Make person1 and person2 reference the same object
            person1 = person2;
            // Change the name of person2 and notice that person1 changes
            person2.Name = "Molly";
            person2.Age = 16;
            Console.WriteLine($"Person 1 Name: {person1.Name}, age: {person1.Age}");
            Console.WriteLine($"Person 2 Name: {person2.Name}, age: {person2.Age}");
            PrintDivider();

            // Create struct instance and initialize by using "new"
            // Memory is allocated on thread stack
            PersonStruct p1 = new PersonStruct("Alex", 9);
            Console.WriteLine($"P1 Name: {p1.Name}, age: {p1.Age}");
            PrintDivider();

            // Create new struct object. Note that struct can be intialize without using "new"
            PersonStruct p2 = p1;

            // Assign values to p2 members
            p2.Name = "Spencer";
            p2.Age = 7;
            Console.WriteLine($"P2 Name: {p2.Name}, age: {p2.Age}");
            Console.WriteLine($"P1 Name: {p1.Name}, age: {p1.Age}");
            PrintDivider();

            // To determine if two variables refer to the same object
            Console.WriteLine($"Do person1 and person2 refer to the object? {person1.Equals(person2)}");

            // To determin if the fields of two struct instances are the same
            Console.WriteLine($"Do p1 and p2 have the same values? {p1.Equals(p2)}");

            p1.Name = p2.Name;
            p1.Age = p2.Age;
            Console.WriteLine($"Do p1 and p2 have the same values? {p1.Equals(p2)}");
            PrintDivider();

            ////////////////////////////////////////////////////////////////////////////////////////////////
            // Create an instance of WorkItem by using the constructor in the base class that takes 3 arguments
            WorkItem item = new WorkItem("Fix Bugs", 
                                         "Fix all bugs in my code branch", 
                                         new TimeSpan(3, 4, 0, 0));
            // Create an instance of ChangeRequest by using the constructor in the derived class that takes 4 
            // arguments
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                     "Add members to the class",
                                                     new TimeSpan(4, 0, 0),
                                                     1);
            // Use the ToString method defined in WorkItem
            Console.WriteLine(item.ToString());
            PrintDivider();

            // Use the inherited Update method to change the title of the ChangeRequest object
            change.Update("Change the Design of the Base Class",
                           new TimeSpan(4, 0, 0));
            // ChangeRequest inherits WorkItem's override of ToString
            Console.WriteLine(change.ToString());
            PrintDivider();
        }

        static void PrintDivider()
        {
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
