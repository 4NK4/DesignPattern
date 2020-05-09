using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class AccessServer: IServer
    {
        public void Insert(User user)
        {
            Console.WriteLine("AcceessServer--中插入一条记录!");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("AccessServer --获取了一条记录!");
            return null;
        }
    }
}
