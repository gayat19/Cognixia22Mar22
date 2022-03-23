using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApplication
{
    internal class UnderstandingStatic
    {
        int instanceNumber = 0;
        static int staticNumber = 0;
        public void IncrementNumbers()
        {
            instanceNumber++;
            staticNumber++;
        }
        public void PrintNumbers()
        {
            Console.WriteLine("Value of instance numebr is "+instanceNumber);
            Console.WriteLine("Value of static numebr is " + staticNumber);
        }
    }
}
