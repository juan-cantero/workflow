using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine.strategies
{
    public class TijeraStrategy : ITask
    {
        public void Run()
        {
            Console.WriteLine("tijera");
        }
    }
}
