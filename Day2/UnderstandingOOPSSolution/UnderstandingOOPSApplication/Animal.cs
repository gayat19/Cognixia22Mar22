using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApplication
{
    abstract internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Munch munch");
        }
        public abstract void Move();
        //public virtual void Move();
        //{
        //    Console.WriteLine("Animal moves");
        //}
    }
    class Horse: Animal
    {
        public override void Move()
        {
            Console.WriteLine("Tok tok tok");
        }
    }
    class Donkey : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Toka.... tok ");
        }
    }
}
