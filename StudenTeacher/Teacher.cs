using System;

namespace StudenTeacher
{
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine($"Explination begins");
        }
    }
}
