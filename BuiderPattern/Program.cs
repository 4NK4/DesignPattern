using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderPattern
{
    /// <summary>
    /// 建造者模式让达成目标的流程固定,不至于遗漏
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PersonFat personFat = new PersonFat("SVG", "钢笔");
            PersonDirector personDirector = new PersonDirector(personFat);
            personDirector.CreatePerson();
            Console.ReadLine();
        }
    }
}
