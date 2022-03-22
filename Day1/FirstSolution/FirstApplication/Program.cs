using System;

namespace FirstApplication
{
    internal class Program
    {
        static int num1, num2;
        static void TakeTwoNumbers()
        {
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        static void FindTheGreatestOfTwoNumebrs()
        {
            TakeTwoNumbers();
            if (num1 == num2)
                Console.WriteLine("The numebrs are equal");
            else if(num1>num2)
                Console.WriteLine("The first number "+ num1 +" is greatest");
            else
                Console.WriteLine("The second number " + num2 + " is greatest");
        }
        static void GreatestOfTen()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Please enter the {i+1}th number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int greatest = 0;
            Console.WriteLine("The numebrs you have enterter are ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                if(greatest<numbers[i])
                    greatest = numbers[i];
            }
            Console.WriteLine("The greatest in these numbers - "+greatest);
        }
        static void Add()
        {
            TakeTwoNumbers();
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        }
        static void PrintGreet()
        {
            string name;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome to C# {name}");
        }
        static void Main(string[] args)
        {
           GreatestOfTen();
            Console.WriteLine("Hello world");
        }
    }
}
