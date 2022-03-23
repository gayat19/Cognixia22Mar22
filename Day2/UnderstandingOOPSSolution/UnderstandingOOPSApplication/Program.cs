using System;

namespace UnderstandingOOPSApplication
{
    internal class Program
    {
        void Exisit(IHuman human)
        {
            human.Eat();
            human.Live();
            human.Sleep();
        }
        void Work(IManage manage)
        {
            manage.DoReview();
            manage.ConductMeeting();
        }
        static void Main(string[] args)
        {
            //Animal animal = new Horse();
            //animal.Eat();
            //animal.Move();
            BankManager bankManager = new BankManager();
            Program program = new Program();    
            program.Exisit(bankManager);
            program.Work(bankManager);
        }
    }
}
