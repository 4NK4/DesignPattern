using System;

namespace FactoryPattern
{
    class SqlServer:IServer
    {
        public void Insert(User user)
        {
            Console.WriteLine("SQLServer--中插入一条记录!");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("SQLServer --获取了一条记录!");
            return null;
        }
    }
}
