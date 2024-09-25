using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber.Models
{
    internal class Armstrong
    {
        static int divisor = 10;
        public static bool IsArmstrong(int number)
        {
            double answer = 0;
            int numberOfDigits = CalculateDigits(number);
            int temp = number;

            //Calculate te power of each digit 
            while (number > 0)
            {
                int digit = number % divisor;
                number = number / divisor;
                answer = answer + Math.Pow(digit, numberOfDigits);
            }

            //Check for armstrong number
            if (answer == temp)
            {
                return true;
            }
            return false;
        }

        //Calculate the number of digits
        static int CalculateDigits(int number)
        {
            int count = 0;

            while (number > 0) { 
                number = number / divisor;
                count++;
            }
            return count;

        }
    }
}
