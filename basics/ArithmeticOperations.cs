// Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing
//  two numbers entered by the user.

using System;

namespace ArithmeticOperationProgram
{
    public class  Arithmeticoperatio
    {
        public static void Main(string[] args)
        {
            int num1 , num2, result;
            
            Console.WriteLine("Enter 2 value for Perform Arithmetic Operation's ");
            Console.Write("Enter Value 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Output : ");
            result = num1 + num2;
            Console.WriteLine("Addition Of two Number's : {0} + {1} = {2}",num1, num2, result);
            
            result = num1 - num2;
            Console.WriteLine("Subtraction Of two Number's : {0} - {1} = {2}",num1, num2, result);
            
            result = num1 * num2;
            Console.WriteLine("Multiplication Of two Number's : {0} x {1} = {2}",num1, num2, result);
            
            result = num1 / num2;
            Console.WriteLine("Multiplication Of two Number's : {0} / {1} = {2}",num1, num2, result);
            
            
        }
    }
}