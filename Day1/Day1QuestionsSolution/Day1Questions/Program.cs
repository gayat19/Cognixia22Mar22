using System;

namespace Day1Questions
{
    internal class Program
    {
        static string cardnumber;
        static int[] reverseCardNumebr = new int[16];
        static void GetCardNumebr()
        {
            Console.WriteLine("Please enter a 16 digit card numebr"); ;
            cardnumber = Console.ReadLine();
        }
        static void ReverseCardNumber()
        {
            for (int i = 0; i < cardnumber.Length; i++)
            {
                int number = Convert.ToInt32(cardnumber[i].ToString());
                reverseCardNumebr[15-i] = number;
            }
        }
        static void CheckCard()
        {
            int sum = 0;
            for (int i = 0; i < reverseCardNumebr.Length; i++)
            {
                if(i%2 == 1)
                {
                    reverseCardNumebr[i] *= 2;
                    if (reverseCardNumebr[i] > 9)
                        reverseCardNumebr[i] -= 9;
                }
                sum += reverseCardNumebr[i];
            }
            if(sum%10==0)
                Console.WriteLine("Valid card");
            else
                Console.WriteLine("Invaid card");
        }
        static void Main(string[] args)
        {
            GetCardNumebr();
            ReverseCardNumber();
            CheckCard();
            Console.WriteLine("Hello World!");
        }
    }
}
