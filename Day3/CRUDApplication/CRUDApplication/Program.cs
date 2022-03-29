using CRUDApplication.Services;
using System;

namespace CRUDApplication
{
    internal class Program
    {
        ManagePizzas managePizza ;
        ManageCart manageCart ;
        Program()
        {
            managePizza = new ManagePizzas();
            manageCart = new ManageCart(managePizza);
        }
        void PrintMenu()
        {
            Console.WriteLine("Welcome to the Pizza Store");
            Console.WriteLine("1. View Pizzas");
            Console.WriteLine("2. Buy Pizzas");
            Console.WriteLine("3. View Cart");
            Console.WriteLine("4. Place Order");
            Console.WriteLine("0. Exit");
        }
        void UserInterface()
        {
            Console.WriteLine("Lets start the store by adding pizzas");
            managePizza.AddPizzas();
            Console.WriteLine("Pizzas ready. Open store");
            int choice = 0;
            do
            {
                PrintMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:managePizza.PrintAllPizzas();
                        break;
                    case 2:
                        Console.WriteLine("Enter the pizza id for adding it to teh cart");
                        int id = Convert.ToInt32(Console.ReadLine());
                        manageCart.AddToCart(id);
                        break;
                    case 3:
                        manageCart.PrintCart();
                        break;
                    case 4:
                        Console.WriteLine("Order placed. Will reach you in 30 minutes");
                        Console.WriteLine("Happy eating");
                        manageCart.ClearCart();
                        break;
                    case 0:
                        Console.WriteLine("Bye........");
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }

            } while (choice != 0);

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.UserInterface();
            
        }
    }
}
