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

        // Find the smallest integer of an array
        public static int FindSmallestInt(int[] args)
        {
            int smallestInt = args[0]; 

            foreach(int num in args)
            {
                if(smallestInt > num)
                {
                    smallestInt = num;
                }
            }

            return smallestInt;
        }

        // A needle in the haystack
        public static string FindNeedle(object[] haystack) => $"found the needle at position {Array.IndexOf(haystack, "needle")}";
        /*
        {
            int pos = 0;
            foreach(object obj in haystack)
            {
                if (obj == "needle")
                {
                    return $"found the needle at position {pos}";
                }
                pos++;
            }
            return "Could not find a needle in the haystack :(";
        }
        */
    }
}
