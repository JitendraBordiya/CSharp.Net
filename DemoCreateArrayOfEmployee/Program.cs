using System;
using System.Collections;

namespace DemoCreateArrayOfEmployee
{
    class Employee
    {
        public int id;
       public string name;
       public string designation;
         public string department;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lis1 = new ArrayList();

            lis1.Add(new Employee() { id = 101, name = "Sourav", designation = "Project Manager", department = "Development" });
            lis1.Add(new Employee() { id = 102, name = "Vinayak", designation = "Full Stack Developer", department = "Development" });
            lis1.Add(new Employee() { id = 103, name = "Ranjan", designation = "Java Developer", department = "Development" });
            lis1.Add(new Employee() { id = 104, name = "Rishabh", designation = "C#.Net Developer", department = "Development" });
            lis1.Add(new Employee() { id = 105, name = "Abhishek", designation = "Ui/Ux DeveLoper", department = "Development" });
            lis1.Add(new Employee() { id = 106, name = "Swapnil", designation = "ReactNativeDeveloper", department = "Development" });

            Console.WriteLine("Code \t Name \t           Designation \t         Department");
            Console.WriteLine("____________________________________________________________");
           
            foreach (Employee o in lis1)
            {
                Console.Write("{0} \t {1} \t {2} \t {3}", o.id, o.name,o.designation,o.department);
                Console.WriteLine();
            }
            Console.WriteLine("____________________________________________________________");

            ArrayList lis2 = new ArrayList();

            lis2.Add(new Employee() { id = 107, name = "Kalyani", designation = "Company Manager", department = "  HRM"});
            lis2.Add(new Employee() { id = 108, name = "Rajesh",  designation = "HR Manager     ", department = "  HRM" });
            lis2.Add(new Employee() { id = 109, name = "Harish",  designation = "HR Recruiter", department = "          HRM" });
            lis2.Add(new Employee() { id = 1010, name = "Raunak", designation =  "HR intern ", department = "          HRM" });
            lis2.Add(new Employee() { id = 1011, name= "Siraj",   designation = "        Support Executive", department = "  HRM" });
            lis2.Add(new Employee() { id = 1012, name= "Rajeswari",designation="Receptionist ", department = "          HRM" });



            Console.WriteLine("Code \t Name \t           Designation \t         Department");
            Console.WriteLine("____________________________________________________________");
            foreach (Employee o in lis2)
            {
                Console.Write("{0} \t {1} \t {2} \t {3}", o.id, o.name,    o.designation, o.department);
                Console.WriteLine();
            }
            Console.WriteLine("____________________________________________________________");


            Console.ReadKey();
        }
    }
}
