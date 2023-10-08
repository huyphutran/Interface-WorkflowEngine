using System;

namespace WorkFlowEngine
{
    class SendNofication : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Notification Sent!!");
        }
    }
}
