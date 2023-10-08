using System.Collections.Generic;

namespace WorkFlowEngine
{
    internal interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTask();
    }
}