using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    ///原型模式,以拷贝的形式,创建一个新的对象,这个新对象在创建过程是高度可定制的.
	///简要使用说明:复印模式.
	///浅复制时,引用类型的数据只复制地址.
	///深复制时,引用类型的数据会复制值.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume = new Resume(10,"王强");
            Company company = new Company("真善美公司", 123456789);
            resume.SetCompany(company);
            resume.Printf();


            Resume resumeColne = (Resume)resume.Clone();
            Company company2 = new Company("真善美公司", 15154);
            resumeColne.SetCompany(company2);
            resumeColne.Printf();


            Console.ReadLine();
        }
    }
}
