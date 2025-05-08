// Multiply Three Numbers

using System;

namespace MultiplyThreeNumber
{
    public class Multiply
    {
        public static void Main(string[] args)
        {
            int a,b,c,d;
            Console.WriteLine("Enter First value : ");
            a = Convert.ToInt32(Console.ReadLine());
    
            Console.WriteLine("Enter Second vale : ");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Third Vlaue : ");
            c = Convert.ToInt32(Console.ReadLine());
            
            d = a * b * c;
            Console.WriteLine("Multiplication of {0} x {1} x {2} = {3}" , a , b, c, d );
            // Console.WriteLine(d);
        }
    }
}