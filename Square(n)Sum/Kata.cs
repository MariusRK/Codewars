using System;
using System.Collections.Generic;
using System.Text;

namespace Square_n_Sum
{
    class Kata
    {
        // Squares all numbers in an array and returns the sum of all. 
        public static int SquareSum(int[] n)
        {
            int sum = 0;

            foreach (int i in n)
            {
                sum += i * i;
            }

            return sum;
        }

        // Converts a number to string
        public static string NumberToString(int num)
        {
            return num.ToString();
        }

        // Gets the middle character(s) of a string
        public static string GetMiddle(string s)
        {
            if(s.Length == 1)
            {
                return s.ToString();
            }
            else if(s.Length % 2 == 0)
            {
                return s[s.Length / 2 - 1].ToString() + s[s.Length/2];
            }
            else
            {
                return s[s.Length / 2].ToString();
            }
        }
    }
}
