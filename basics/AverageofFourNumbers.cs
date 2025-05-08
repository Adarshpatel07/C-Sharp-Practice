//Program to calculate the average of four numbers

using System;

namespace AverageOfFourProgram
{
    public class Average 
    {
        public static void Main(string[] args)
        {
            int num1,num2,num3,num4;
            
            Console.WriteLine("Enter the values to calculate the average of four number you have to enter four values one by one") ;
            Console.Write("Enter value first : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter value second : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter value third : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter value fourth :");
            num4 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("The Average is : {0}",(num1+num2+num3+num4)/4);
        }
    }
}
