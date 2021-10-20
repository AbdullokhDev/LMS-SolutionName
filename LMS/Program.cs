using System;

namespace LMS
{
    class Program
    {
        static void Main(string[] args)
        {
            // class name is Person we are referring
            // variable name is person
            Person person = new Person();
            // now to time fill the fields which is proporties in the Person class that we created

            person.Name = "Abdullokh";
            person.Age = 22;
            person.HasPet = false;

            person.Introduce();
        }
    }
}
