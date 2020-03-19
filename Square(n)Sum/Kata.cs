using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        // Reversing strings
        public static string ReverseString(string str) => new string(str.Reverse().ToArray());
        /*
        {
            string reversed = "";

            for(int i = str.Length-1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }
        */

        public static string DnaToRna(string dna) => dna.Replace('T', 'U');
        /*
        {
            string rna = "";

            foreach(char c in dna)
            {
                if(c == 'T')
                {
                    rna += 'U';
                }
                else
                {
                    rna += c;
                }
            }

            return rna;
        }
        */

        // Converts all words in a string to start with uppercase
        public static string ToJadenCase(string phrase)
        {
            string jadenCasedPhrase = "";

            for(int i = 0; i < phrase.Length; i++)
            {
                if (jadenCasedPhrase == "")
                {
                    jadenCasedPhrase += phrase[i].ToString().ToUpper();
                    continue;
                }

                jadenCasedPhrase += phrase[i];
                
                if (phrase[i] == ' ')
                {
                    jadenCasedPhrase += phrase[i + 1].ToString().ToUpper();
                    i++;
                }
            }

            return jadenCasedPhrase;
        }

        // Counts the number of people on a bus
        public static int Number(List<int[]> peopleListInOut)
        {
            int peopleOnTheBus = 0;

            for(int i = 0; i < peopleListInOut.Count; i++)
            {
                peopleOnTheBus += peopleListInOut[i][0];
                peopleOnTheBus -= peopleListInOut[i][1];
            }

            return peopleOnTheBus;
        }

        // Returns the sum of all multiples of 3 and 5
        public static int FindSum(int n)
        {
            int sum = 0;

            for(int i = 0; i <= n; i++)
            {
                if(i % 3 == 0)
                {
                    sum += i;
                }
                else if(i % 5 == 0)
                {
                    sum += i;
                }

                Console.WriteLine(sum);
            }

            return sum;
        }

        // Returns a number in expanded form
        /*
        public static string ExpandedForm(long num)
        {
            string strNum = num.ToString();

            int numberOfZeroes = 0;

            List<string> expandedNum = new List<string>();

            for (int i = strNum.Length - 1; i >= 0; i--)
            {
                int number = str

                for(int j = 0; j < numberOfZeroes; j++)
                {
                    if(numberOfZeroes == 0)
                    {
                        continue;
                    }
                }
            }

            for(int k = 0; k < expandedNum.Count; k++)
            {
                Console.WriteLine(expandedNum[k]);
            }

            return "";
        }
        */

        // Converts a camel cased string to a string with spaces between words
        public static string BreakCamelCase(string str)
        {
            string nonCamelCasedString = "";

            foreach(char c in str)
            {
                if(c.ToString() == c.ToString().ToUpper())
                {
                    nonCamelCasedString += " ";
                }
                nonCamelCasedString += c;
            }

            return nonCamelCasedString;
        }
    }
}
