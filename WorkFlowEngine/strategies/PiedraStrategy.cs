using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine.strategies
{
    public class PiedraStrategy : ITask
    {
        public void Run()
        {
            Console.WriteLine("piedra");
        }
    }
}
