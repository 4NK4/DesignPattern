using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IServer iserver = Factorycs.GetServer(ServerEnum.AccessServer);

            iserver.Insert(new User());
            iserver.GetUser(100);

            Console.ReadLine();
        }

    }
}
