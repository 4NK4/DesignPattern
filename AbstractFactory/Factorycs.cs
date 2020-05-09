using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public enum ServerEnum
    {
        SQLserver,
        AccessServer
    }

    /// <summary>
    /// 可以尝试将下列的new的对象变为单例模式
    /// </summary>
    class Factorycs
    {
        public static IServer GetServer(ServerEnum serverEnum)
        {
            IServer server = null;
            switch (serverEnum)
            {
                case ServerEnum.SQLserver:
                    server = new SqlServer();
                    break;
                case ServerEnum.AccessServer:
                    server = new AccessServer();
                    break;
            }
            return server;

        }

    }
}
