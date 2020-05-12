using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class Paint : Software
    {
        public override void Operation()
        {
            Console.WriteLine("打开了画图工具!");
        }
    }
}
