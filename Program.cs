using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bey Alghozy", 21);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Kamarudin", 35, "190302", "Pemrograman");
            teacher.GetNameAndAge();

            Student student = new Student("Bey Alghozy", 21, "19.11.2640", "muhammad.2903@students.@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}