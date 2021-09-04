using System;

namespace TicketBookingApp
{
    public class Booking
    {
       
       
        public void Book(int ticket ,int UserBooking)
        {
            for (int i = 1; i <= 1; i++)
            {
                if (UserBooking == 0)
                {
                    throw (new ChoiceIsZeroException("BooK Atleast 1 ticket"));
                }
                else if (UserBooking > ticket)
                {
                    throw (new InvalidInputException("UserBooking in Greater Than Total Tickets"));
                   
                }
                else if (UserBooking >2)
                {
                    throw (new OutOfLimitException("Exeeds The Booking Limit One Person Book Only 2 Tickets"));
                }
                else
                {
                    ticket -= UserBooking;
                    Console.WriteLine(UserBooking + " Tickets Booked");
                    Console.WriteLine("Total Tickets Remaining {0} ", ticket);
                   
                }
                

            }
            
        }
 
    }
    public class ChoiceIsZeroException : ApplicationException
    {
        public ChoiceIsZeroException(string message) : base(message)
        {

        }

    }
    public class InvalidInputException : ApplicationException
    {
        public InvalidInputException(string message) : base(message)
        {

        }

    }
    public class OutOfLimitException : ApplicationException
    {
      

        public OutOfLimitException(string message) : base(message)
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Booking b1 = new Booking();
            try
            {
                int ticket = 20;
                Console.Write("Please Enter Number Of Bookings : ");
                int UserBooking = Convert.ToInt32(Console.ReadLine());
                b1.Book(ticket, UserBooking);
                Console.ReadKey();

            }
            catch(ChoiceIsZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (OutOfLimitException e1)
            {
                Console.WriteLine(e1);
            }
            catch(InvalidInputException e2)
            {
                Console.WriteLine(e2);
            }
        }
    }
}
