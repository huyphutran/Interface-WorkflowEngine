using System;

namespace WorkFlowEngine
{
    class CallWebServices : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Services is called");
        }
    }
}
