using System;
using System.Data.SqlClient;
using Appraisal;

namespace AppraisalHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            char Choice;
            string Id;
            string Name;
            string DeptNo;
            string DeptName;
            string CurrRole;
            string NewRole;
            int AppNo;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            //Console.Write("UserName :");
            //string UserName = Console.ReadLine();
            //Console.Write("Pass :");
            //string PassWord = Console.ReadLine();




            Console.BackgroundColor = ConsoleColor.Black;
          
            Apraisal.CreateConnection();
             Console.WriteLine("Connection SuccessFul");
            Console.WriteLine("############################################################");

            Console.WriteLine("          WelCome To T-Company    ");
            Console.WriteLine("############################################################");

            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 to Check The Details Of Employee");
            Console.WriteLine("2 to Add New Data");
            Console.WriteLine("3 TO Update the Data");
            Console.WriteLine("4 TO HighAppraisal Employee's  Data");
            Console.WriteLine("5 Delete The Data");
            Console.WriteLine("6 Main menu");
            Console.WriteLine("Press Y to Continue");
            Console.WriteLine("_____________________________________________________________");

            do
            {
                Console.WriteLine("_____________________________________________________________");


                Console.WriteLine("Enter Your Choice");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                    { 
                   case 1:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;

                        Apraisal.DisplayData();
                        Console.WriteLine(" Press 6 Main menu");
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine("Enter Your Details");
                        Console.Write("Enter ID : ");
                        Id = Console.ReadLine();
                        Console.Write("Enter Name : ");
                        Name = Console.ReadLine();
                        Console.Write("Enter DeptID : ");
                        DeptNo = Console.ReadLine();
                        Console.Write("Enter DeptName : ");
                        DeptName = Console.ReadLine();
                        Console.Write("Enter Your Role : ");
                        CurrRole = Console.ReadLine();
                        Console.Write("Enter Your New Role : ");
                        NewRole = Console.ReadLine();
                        Console.Write("Enter No of Appraisal : ");
                        AppNo = Convert.ToInt32(Console.ReadLine());
                        Apraisal.InsertData(Id, Name, DeptNo, DeptName, CurrRole, NewRole, AppNo);
                        Console.WriteLine(" Press 6 Main menu");

                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.Write("Enter ID : ");
                        Id = Console.ReadLine();
                        Console.Write("Enter Your New Role : ");
                        NewRole = Console.ReadLine();
                        Console.Write("Enter Your AppNo : ");
                        AppNo = Convert.ToInt32( Console.ReadLine());
                        Apraisal.UpdateData( NewRole, Id,AppNo);
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Employees List Who Are Intern Now Managers");
                        Apraisal.HighAppData();
                        Console.WriteLine(" Press 6 Main menu");
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write("Enter ID : ");
                        Id = Console.ReadLine();

                        Apraisal.DeleteData(Id);
                        Console.WriteLine(" Press 6 Main menu");
                        break;
                    case 6:
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("Enter Your Choice");
                        Console.WriteLine("1 to Check The Details Of Employee");
                        Console.WriteLine("2 to Add New Data");
                        Console.WriteLine("3 TO Update the Data");
                        Console.WriteLine("4 TO HighAppraisal Employee's  Data");
                        Console.WriteLine("5 Delete The Data");
                        Console.WriteLine("6 Main menu");
                        Console.WriteLine("_____________________________________________________________");


                        break;

                }
                Console.Write("Want To revisit Data Press Y :");
                 Choice = Convert.ToChar(Console.ReadLine());
            } while(Choice == 'Y');

            Console.Read();

            
        }
    }
}
