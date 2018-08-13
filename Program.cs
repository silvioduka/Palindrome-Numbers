/*
Palindrome Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-04

Palindromic number is a number that is the same when written forwards or backwards. 
Create a program that takes a number as input and return whether the number is palindromic, or not. 

For Example: 
645 - Not a Palindrome 
656 - Palindrome 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 65432123456; // Insert a number to verify

            string sNumber = number.ToString();
            int l = sNumber.Length;
            bool b = true;

            for (int i = 0; i < l / 2; i++)
            {
                if (sNumber[i] != sNumber[l - i - 1]) { b = false; break; }
            }

            Console.WriteLine($"The number {number} - {((b == true)?"Palindrome":"Not a Palindrome")}");
        }
    }
}