using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApplication
{
    internal  class BankManager : Employee, IHuman, IManage
    {

        public  void ConductMeeting()
        {
            Console.WriteLine("Manager conducts meetings");
        }
        public void DoReview()
        {
            Console.WriteLine("Reviews teh work and gives score");
        }

        public void Eat()
        {
            Console.WriteLine("All human eat");
        }

        public void Live()
        {
            Console.WriteLine("Breathe to live. Inhale.......Exale");
        }

        public void Sleep()
        {
            Console.WriteLine("7 Star snooze zzzzzzzzzzzzzzzzzzzzzzzzz");
        }
    }
}
