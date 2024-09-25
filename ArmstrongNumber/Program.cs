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

            if (Armstrong.IsArmstrong(number))
            {
                Console.WriteLine($"The number {number} is Armstrong Number.");
            }
            else 
            {
                Console.WriteLine($"The number {number} is not an Armstrong Number");
            }
        }
    }
}
