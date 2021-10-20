using System;
using System.Collections.Generic;
using System.Text;

namespace LMS
{
    class Person
    {
        // Creating fields(proporties) called Name, age, pet for objects
        public string Name;
        public int Age;
        public bool HasPet;

        // Method called Intoduce void keyword is used because of it should not return anything so that we do not use it in future
        public void Introduce()
        {
            // build in function
            Console.WriteLine("Hello, my name is " + Name + " and my age is " + Age);
        }
    }
}
