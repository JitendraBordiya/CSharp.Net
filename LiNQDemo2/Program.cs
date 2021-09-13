using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiNQDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string conn = "Data Source=LAPTOP-FS8H47HQ\\DBSERVER;Initial Catalog=MyTQdb;Integrated Security=true";
            DataClasses1DataContext emp = new DataClasses1DataContext(conn);
            Employee e1 = new Employee();
            e1.Name = "Rajan";
            e1.Email = "Rajan18@mail.com";
            e1.ContactNo = "7488938777";
            e1.DeptId = 2;
            e1.Address = "gwalior";
            emp.Employees.InsertOnSubmit(e1);
            emp.SubmitChanges();
            Console.WriteLine("Record Inserted");
            Console.ReadKey();


        }
    }
}
