using System;


namespace InsuranceInquiry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int age = Convert.ToInt32(yourAge);
            Console.WriteLine("Have you ever had a DUI Violation? (i.e.,driving under alchohol influence).Please write true or false ");
            string haveDui = Console.ReadLine();
            bool dui = Convert.ToBoolean(haveDui);
            Console.WriteLine("How many speeding tickets do yo have?");
            string speedTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(speedTickets);
            Console.WriteLine(age > 15 && tickets < 3 && dui == false);
            Console.ReadLine();
        }
    }
}
