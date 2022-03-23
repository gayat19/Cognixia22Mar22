using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApplication
{
    internal class Mobile
    {
        //default access specifier inside class is private
        int speed;
        public Mobile()
        {

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="color">Phone color</param>
        /// <param name="number">Phone number</param>
        /// <param name="make">The company</param>
        public Mobile(string color, string number, string make)
        {
            Color = color;
            Number = number;
            Make = make;
        }

        private string number;
        public string Color { get; set; }
        public string Number
        {
            get {
                string maskedNumber = "XXXXXXX" + number.Substring(7, 3);
                return maskedNumber; 
            }
            set { number = value; }
        }
        public string Make { get; set; }
        public void MakeCall(string number)
        {
            Console.WriteLine("Calling "+number+"......");
        }
        public void MakeCall(string number,string code)
        {
            Console.WriteLine("Calling " + code+" "+number + "......");
        }
        public void ReceiveCall()
        {
            Console.WriteLine("Tring tring");
            Console.WriteLine("Receiving call for "+Number);
        }
        public  static void Common()
        {
            Console.WriteLine("can be used by all objects");
        }
    }
}
