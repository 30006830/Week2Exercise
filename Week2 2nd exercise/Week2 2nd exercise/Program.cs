using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_2nd_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for the user to enter a number. The number will be recorded and stored inside a variable.
            Console.WriteLine("Please enter a number: ");
            var num1 = int.Parse(Console.ReadLine());

            //a second number is asked for from the program to the user to be entered. Will also be stored in a variable.
            Console.WriteLine("Enter another number: ");
            var num2 = int.Parse(Console.ReadLine());

            /*this entire strand of code is meant to calculate each form of practical mathematics from the numbers entered to the console by the user*/
            int total = num1 + num2;
            int total1 = num1 - num2;
            int total2 = num1 * num2;
            int total3 = num1 / num2;

            //displays each of the totals (total, total1, total2, total3) from the variables stored in a listed format.
            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, total1);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, total2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, total3);


            Console.ReadLine();
        }
    }
}
