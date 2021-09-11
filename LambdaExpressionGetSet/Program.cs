using System;
using System.Collections.Generic;
using System.Linq;
namespace LambdaExpressionGetSet
{
    class Student
    {
        public string Name { get; set; }
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Student = new List<Student>() {
                new Student { Name = "Harry", age = 24 },
                new Student {Name ="Ron",age=20},
                new Student {Name="Draco",age=26 },
                new Student { Name="Milind",age =23}
                 };
            var names = Student.Select(x => x.Name);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.Read();
        }

    }
}
