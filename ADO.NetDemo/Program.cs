using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NetDemo
{
   public class Employee1
    {
        public string cons;
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;
        public static void CreateConnection()
        {
            string cons = "Data Source=LAPTOP-FS8H47HQ\\DBSERVER;Initial catalog=MyTQdb;User Id=sa;password=@123";
            con = new SqlConnection();
            con.ConnectionString = cons;
        }
        public static void InsertData(string Name,string Email,string ContactNo,int DeptId,string Address)
        {
            con.Open();
            string query="Insert Into Employee values('"+Name+"','"+Email+"','"+ContactNo+"','"+DeptId+"','"+Address+"')";

            cmd = new SqlCommand(query, con);
            int r = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} Row,s Affected", r);
                con.Close();
        }
       public static void DisplayData()
        {
            con.Open();
            string query="Select * From Employee";

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Name  \t  Deptid");
            while (dr.Read())
            {
                Console.WriteLine(" {0} \t  {1} ", dr["Name"],dr["DeptId"]);
            }
            dr.Close();
            string cmdCount = "Select Count(*) from Employee";
            cmd = new SqlCommand(cmdCount, con);
            int Count = (int)cmd.ExecuteScalar();
            Console.WriteLine("{0} Records found",Count);
            con.Close();
        }
 }
    class Program
    {
        static void Main(string[] args)
        {
            Employee1.CreateConnection();
            // Employee1.DisplayData();
           
           
          string Name;
          string Email;
          string Contact;
          int dept;
          string address;

            Console.WriteLine("Enter Your Details");
            Name = Console.ReadLine();
            Email = Console.ReadLine();
            Contact = Console.ReadLine();
            dept = Convert.ToInt32(Console.ReadLine());
            address = Console.ReadLine();
            Employee1.InsertData(Name, Email, Contact,dept, address);
            Console.ReadKey();


        }
    }
}
