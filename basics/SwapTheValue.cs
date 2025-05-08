// Write a C# Sharp program to swap two numbers.

using System;

namespace SwapValueProgram
{
    public class SwapValue
    {
        public static void Main(string[] args)
        {
            int a , b , c;
            
            Console.WriteLine("Enter the First Value : ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the Second Value : ");
            b = Convert.ToInt32(Console.ReadLine());
            
            c = a;
            a = b;
            b = c;
            
            Console.WriteLine("The First Enterd Value is : {0} " , a);
            Console.WriteLine("The Second Enterd Value is : {0} ", b);
            
            // Console.Read();
        }
    }
}