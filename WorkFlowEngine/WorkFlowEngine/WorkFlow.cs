using System.Collections.Generic;

namespace WorkFlowEngine
{
    class WorkFlow : IWorkFlow
    {
        private readonly List<ITask> Task;

        public WorkFlow()
        {
            Task = new List<ITask>();
        }

        public void Add(ITask task)
        {
            Task.Add(task);
        }

        public void Remove(ITask task)
        {
            Task.Remove(task);
        }

        public IEnumerable<ITask> GetTask()
        {
            return Task;
        }
    }
}
