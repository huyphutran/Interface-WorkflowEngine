using System;

namespace WorkFlowEngine
{
    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Status: Processing");
        }
    }
}
