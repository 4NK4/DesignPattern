using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class Calculator : Software
    {
        public override void Operation()
        {
            Console.WriteLine("打开了计算器!");
        }
    }
}
