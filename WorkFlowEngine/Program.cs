using System;
using WorkFlowEngine.strategies;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.AddTask(new PiedraStrategy());
            workFlow.AddTask(new TijeraStrategy());
            workFlow.AddTask(new PapelStrategy());
            workFlow.PerformTasks();
        }
    }
}
