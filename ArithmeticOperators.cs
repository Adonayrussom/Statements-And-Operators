using System;

namespace sess03_StatementsAndOperators
{
    /// <summary>
    /// C# program to demonstrate the various arithmetic operators in C#,
    /// </summary>
    public class ArithmeticOperators
    {
        static void Main(string[] args)
        {
            byte firstNum = 8, secondNum = 25;
            int product, sum, quotient, difference, remainder;

            product = firstNum * secondNum;
            sum = firstNum + secondNum;
            quotient = firstNum / secondNum;
            difference = firstNum - secondNum;
            remainder = firstNum % secondNum;


            Console.WriteLine($"{secondNum} * {firstNum} = {product,3}");
            Console.WriteLine($"{secondNum} + {firstNum} = {sum,3}");
            Console.WriteLine($"{secondNum} {'\u00f7'} {firstNum} = {quotient,3}");
            Console.WriteLine($"{secondNum} - {firstNum} = {difference,3}");
            Console.WriteLine($"{secondNum} % {firstNum} = {remainder,3}");

            int postfix = secondNum++;
            int prefix = --firstNum;

            Console.WriteLine($"After postfixing the secondNum variable we get: {postfix}");
            Console.WriteLine($"After prefixing the firstNum variable we get: {prefix}");
            Console.WriteLine($"Value of secondNum after postfixing is: {secondNum}");
            Console.WriteLine($"Value of firstNum after prefixing is: { firstNum}");
        }
    }
}
