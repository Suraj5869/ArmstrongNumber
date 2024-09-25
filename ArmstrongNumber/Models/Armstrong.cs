using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber.Models
{
    internal class Armstrong
    {
        const int divisor = 10;
        const int min = 0;
        public static string CheckArmstrong(int number)
        {
            double answer = 0;
            int numberOfDigits = CalculateDigits(number);
            int temp = number;
            

            //Calculate te power of each digit 
            while (temp > min)
            {
                int digit = temp % divisor;
                temp = temp / divisor;
                answer = answer + Math.Pow(digit, numberOfDigits);
            }

            //Check for armstrong number
            if (answer == number)
            {
                return $"The number {number} is Armstrong Number.";
            }
            return $"The number {number} is not an Armstrong Number";
        }

        //Calculate the number of digits
        static int CalculateDigits(int number)
        {
            int count = 0;

            while (number > min) { 
                number = number / divisor;
                count++;
            }
            return count;

        }
    }
}
