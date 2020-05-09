using System;

namespace AdapterPattern
{
    class Program
    {
        /// <summary>
        /// 适配器模式可以在不改变Targ类和客户端targ对象的前提下,只用添加类文件就能改变同名方法的行为
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
