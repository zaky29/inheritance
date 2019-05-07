using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            person person = new person();
            person.Name = "zaky";
            person.Age = 19;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "dzakwan";
            teacher.Age = 29;
            teacher.TeacherId = "0213290";
            teacher.Subject = "match";
            teacher.GetNameAndAge();

            student student = new student();
            student.Name = "aziz";
            student.Age = 19;
            student.studentId = "18112335";
            student.Email = "zakydan61@gmail.com";
            student.GetNameAndAge();

            Console.ReadKey();


        }
    }
}
