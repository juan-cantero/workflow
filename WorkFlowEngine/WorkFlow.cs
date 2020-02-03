using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine
{
    class WorkFlow
    {
        public List<ITask> Tasks { get; }

        public WorkFlow()
        {
            Tasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            Tasks.Add(task);
        }

        public void PerformTasks()
        {
            Tasks.ForEach(t => t.Run());
        }
    }
}
