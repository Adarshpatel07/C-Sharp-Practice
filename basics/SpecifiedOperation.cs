/*
Write a C# Sharp program to print the results of the specified operations.
Test data:

-1 + 4 * 6
( 35+ 5 ) % 7
14 + -4 * 6 / 11
2 + 15 / 6 * 1 - 7 % 2
*/

using System;

namespace SpecifiedAnswer
{
    public class GetAnswer
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(  -1 + 4 * 6  );//23
            Console.WriteLine( (35 + 5 ) % 7  );//5
            Console.WriteLine( 14 + -4 * 6 / 11 );//12
            Console.WriteLine( 2 + 15 / 6 * 1 - 7 % 2 );//3
        }
    }
}