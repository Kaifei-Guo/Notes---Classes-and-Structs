using System;
using System.Collections.Generic;
using System.Text;

namespace Notes___Classes_and_Structs
{
    // Class definition
    class CustomClass
    {
        // Class members

        // Property
        public int Number { get; set; }
        // Method
        public int Multiply(int num)
        {
            return num * Number;
        }
        // Instance Constructor
        public CustomClass()
        {
            Number = 0;
        }
    }
}
