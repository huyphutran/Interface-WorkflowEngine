using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    internal class WorkFlowEngine
    {
        private readonly List<ITask> Task;

        public WorkFlowEngine()
        {
            Task = new List<ITask>();
        }

        public void Run(IWorkFlow workFlow) { 
        
            foreach (var task in workFlow.GetTask()) {
            
                task.Execute();
            }
        
        }   
    }
}
