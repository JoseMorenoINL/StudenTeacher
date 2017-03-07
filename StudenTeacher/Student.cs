using System;

namespace StudenTeacher
{
    class Student : Person
    {
        public void GoToClasses ()
        {
            Console.WriteLine($"Im going to class");
        }

        public void ShowAge()
        {
            
            Console.Write($"My age is {0}", age );
        }
    }
}
