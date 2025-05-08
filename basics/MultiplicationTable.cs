// This program prints the multiplication table of a given number by the user.
using System;

namespace PrintTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number, i;
            Console.Write("Enter a number to print Table : ");
            number = Convert.ToInt32(Console.ReadLine());
            
            for(i = 1; i <= 10; i++){
            Console.WriteLine("{0} X {1} = {2}",number, i, number * i);
            }
            
        }
    }
}