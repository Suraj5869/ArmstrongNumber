using ArmstrongNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Armstrong.CheckArmstrong(number));

        }
    }
}
