// ############################################################################
// Interview type questions 
// 
// 1."Given an arbitrary list of integers, write functions that will 
// return the sum of all the integers"
//
// 2. "Given a string, write a function that returns true when the string 
// is a palindrome, false otherwise
// 
// 3. "Given 3 arbitrary integer values, write a function that returns their 
// sum. however, if one of the values is 13, then it does not count towards
// the sum, nor does any value "to its right" count. So for example, for 
// integers a, b, and c, if b is 13, then neither b or c count toward the sum.
// 
// Author: Jason Maynard, 2015
// References: www.stackoverflow.com, www.dotnetperls.com
// C# 5.0 Pocket Reference, O'Reilly
//
// ############################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program
    {
        
        // Function for question #1 -------------------------------------------
        // Assumes the data structure is a list
        static int AddThemUp(List<int> list)
        {
            return list.Sum();
        }

        // Function for question #2 -------------------------------------------
        static bool Palindrome(string s)
        {
            string reversed = new String(s.ToCharArray().Reverse().ToArray());
            if (s.Equals(reversed))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Function for question #3 -------------------------------------------
        // Reference: http://quizlet.com/15704758/logic-2-flash-cards/
        // My version is a little different... Was hoping to do with list from 
        // from problem 1 but could not figure out how to deal with the iterator
        // if using a for each loop. 
        static int AddThemUpNoThirteen(int a, int b, int c)
        {
            int total = 0;

            if (a == 13)
            {
                // do nothing
            }
            else if (b == 13)
            {
                total = total + a;
            }
            else if (c == 13)
            {
                total = total + a + b;
            }
            else
            {
                total = a + b + c;
            }

            return total;
        }
        
        static void Main(string[] args)
        {
            // Question 1 -----------------------------------------------------
            // Given an arbitrary list of integers happen to sum to 20
            List<int> theList = new List<int>();
            theList.Add(1);
            theList.Add(13);
            theList.Add(6);

            // Call function to get sum of integers
            Console.WriteLine("Question 1. \nThe sum of integers is: " 
                + AddThemUp(theList));

            // Question 2 -----------------------------------------------------
            // A palindrome string such as "abba"
            string p = "abba";

            // A non-palindrome string such as "notabba"
            string np = "notabba";

            Console.WriteLine("\nQuestion 2");
            Console.WriteLine("A palindrome p is:" + Palindrome(p));
            Console.WriteLine("A non-palindrome np is:" + Palindrome(np));

            // Question 3 -----------------------------------------------------
            // Tried to do this as a list with foreach but think the key 
            // is linked to having 3 specifice integers a, b, c
            int a = 1;
            int b = 13;
            int c = 3;

            Console.WriteLine("\nQuestion 3. \nThe sum of integers without 13 is:"
                + AddThemUpNoThirteen(a, b, c));

            // Do something to keep the widow open...     
            // Note: could also set breakpoint and run in debug mode
            // perhaps set a breakpoint at return 0... 
            #if DEBUG
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            #endif
        }
    }
}
