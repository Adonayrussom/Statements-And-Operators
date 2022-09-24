using System;

namespace sess03_StatementsAndOperators
{
    public class OddOrEvenTernary
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please enter a number and i'll tell you if it's odd or even ->");
            uint userNum = Convert.ToUInt32(Console.ReadLine());

            //Use the ternary operator to evaluate and display the answer/result
            Console.WriteLine(userNum % 2 == 0 ? $"{userNum} is an even number." : $"{userNum} is an odd number.");
        }
    }
}
