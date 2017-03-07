using System;

namespace StudenTeacher
{
    class Person
    {
        protected int age;
        public void SetAge(int n)
        {
            age = n;
            Console.WriteLine($"Age {age}");
           
        }

        public void Greet()
        {
            Console.Write($"Hello!");
        }
    }
}
