using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // this is a excerise 3
        static void Main(string[] args)
        {
            // The asks the user for their dollar amount 
            Console.WriteLine("What is princiipal amount of the loan in dollars?");
            double Principal = Convert.ToDouble(Console.ReadLine());
            //This prints it out 
            //This ask the user for the interest rate  
            Console.WriteLine("What is the interest rate (input 0.05 for 5%)?");
            double Rate = Convert.ToDouble(Console.ReadLine());
            //this prints it out
            //this ask for years 
            Console.WriteLine("What is period of loan in years?");
            double Time = Convert.ToDouble(Console.ReadLine());
            //this prints it out
            //this prints out the total amount
            double Total = Principal * Rate * Time;
            Console.WriteLine("Total interest of Loan:" + Total + " dollars.");
            Console.ReadLine();
            // i put Console.ReadLine(); it would not let you see the final answer for less than a second


        }
    }
}