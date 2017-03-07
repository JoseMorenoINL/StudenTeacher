using System;

namespace StudenTeacher
{
    class Program
    {
        static void Main(string[] args)
        {

            Person persona = new Person();
            persona.Greet();
            Student student1 = new Student();
            student1.Greet();
            student1.SetAge(21);
            Teacher teacher1 = new Teacher();
            teacher1.SetAge(30);
            teacher1.Greet();
            teacher1.Explain();
            
            Console.ReadLine();
        }
    }
}
