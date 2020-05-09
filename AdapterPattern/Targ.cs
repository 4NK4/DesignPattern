using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Targ
    {
        public virtual void GetTarg()
        {
            Console.WriteLine("这是一个普通目标!");
        }

    }
}
