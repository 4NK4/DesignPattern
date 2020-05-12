using System;

namespace AdapterPattern
{
    class Program
    {
        /// <summary>
        /// 适配器模式的主要目的是:改变对象已有方法的行为
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Targ targ = new Adapter();
            targ.GetTarg();
            Console.ReadLine();
        }
    }
}
