// Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.

using System;

namespace AverageOfFourProgram
{
    public class Average 
    {
        public static void Main(string[] args)
        {
            int x,y,z;
            Console.Write("Enter the value of X :");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the value of Y :");
            y = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the value of X :");
            z = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The result for the appropriat formula X + Y . Z = {0}, And the result for appropriat formula x.y + y.z = {1}", (x + y) * z , (x * y) + (y*z));
            
        }
    }
}
