using System;

namespace sess03_StatementsAndOperators
{
    /// <summary>
    /// C# program to demonstrate the various comparison operators in C#
    /// </summary>
    public class ComparisonOperators
    {
        static void Main(string[] args)
        {
            int firstNum = 5, secondNum = 8, thirdNum = firstNum;

            Console.WriteLine("Number comparison between 5, 8 and 5");
            Console.WriteLine($"{firstNum} > {secondNum} is {(firstNum > secondNum)}");
            Console.WriteLine($"{firstNum} < {secondNum} is {(firstNum < secondNum)}");
            Console.WriteLine($"{firstNum} >= {secondNum} is {(firstNum >= secondNum)}");
            Console.WriteLine($"{firstNum} <= {secondNum} is {(firstNum <= secondNum)}");
            Console.WriteLine($"{firstNum} == {secondNum} is {(firstNum == secondNum)}");
            Console.WriteLine($"{firstNum} != {secondNum} is {(firstNum != secondNum)}");
            Console.WriteLine($"{firstNum} == {thirdNum} is {(firstNum == thirdNum)}");
            Console.WriteLine($"{firstNum} != {thirdNum} is {(firstNum != thirdNum)}");
        }
    }
}