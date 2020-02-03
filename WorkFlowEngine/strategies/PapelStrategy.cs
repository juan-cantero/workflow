using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine.strategies
{
    public class PapelStrategy : ITask
    {
        public void Run()
        {
            Console.WriteLine("papel");
        }
    }
}
