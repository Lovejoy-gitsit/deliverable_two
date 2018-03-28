using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //declare variables
            DateTime firstDate;
            DateTime secondDate;


            //asking for user input
            Console.WriteLine("Enter a date mm/dd/yyyy: ");
            //getting user input and converting info to date
            firstDate = Convert.ToDateTime(Console.ReadLine()); 
                                                               

            //asking for user input
            Console.WriteLine("Enter a date mm/dd/yyyy: ");
            //getting user input and converting info to date
            secondDate = Convert.ToDateTime(Console.ReadLine());

            //getting the difference of the dates and naming the variable for it
            var diff = secondDate - firstDate;
            //printing the difference of the dates in days
            Console.WriteLine("diff.Days: " + diff.Days);
            //printing the difference of the dates in hours
            Console.WriteLine("diff.Hours: " + diff.Hours);
            //printing the difference of the dates in minutes
            Console.WriteLine("diff.minutes: " + diff.Minutes);

            Console.ReadLine();
        }
    }
}
