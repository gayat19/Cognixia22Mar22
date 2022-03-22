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
        static int[] Take10Numebrs()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Please enter the {i + 1}th number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }
       static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine("The numebrs you have enterter are ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void GreatestOfTen()
        {
            int[] numbers = Take10Numebrs();
            int greatest = 0;
            PrintNumbers(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (greatest < numbers[i])
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
        static void UndertsandingWhile()
        {
            int[] numbers = Take10Numebrs();
            Console.WriteLine("Pelase enter the numebr to be found");
            int number = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            int count = 0;
            while(count<10)
            {
                if(numbers[count] == number)
                {
                    flag = true;
                    break;
                }
                count++;
            }
            if (flag)
            {
                Console.WriteLine($"The number {number} is present in the list");
            }
        }
        static void FindAverageOfnumbers()
        {
            int number;
            int sum = 0;
            int count = 0;
            do
            {
                Console.WriteLine("Pelase enter a number. To exit enter a negative number");
                number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
                count++;

            } while (number>0);
            int avg = sum / (count - 1);
            Console.WriteLine("Teh average is "+avg);
        }
       /// <summary>
       /// Method takes numbers from user. If size is not -1 then the numebr of numbers taken is the size.
       /// If size is -1 then the method takes numbers until user enters 0
       /// </summary>
       /// <param name="size"></param>
       /// <returns></returns>
        static int[] TakeNumebrs(int size)
        {
            int[] numbers;
            if (size == 0)
            {
                int count = 0;
               numbers = new int[20];
                do
                {
                    numbers[count] = int.Parse(Console.ReadLine());
                    count++;
                } while (numbers[count-1] > 0);
            }
           else
            {
                numbers = new int[size];
                for (int i = 0; i < size; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return numbers;
        }
        static void FindMode()
        {
            int[] unique = new int[20];
            int[] numbers = TakeNumebrs(0);
            Array.Sort(numbers);
            int heighest =0,final =0,mode= 0;
            int number = numbers[0];
            for (int i = 1;i < unique.Length; i++)
            {
                if (number == numbers[i])
                {
                    heighest++;
                    mode = numbers[i];
                }
                else
                {
                    if (final < heighest)
                    {
                        final = heighest;
                        mode = number;
                    }
                    number = numbers[i];
                    heighest = 0;
                }
            }
            Console.WriteLine("Mode is "+mode);
        }
        static void Main(string[] args)
        {
            FindMode();
            Console.WriteLine("Hello world");
        }
    }
}
