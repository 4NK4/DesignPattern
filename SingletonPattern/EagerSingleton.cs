using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 饿汉式单例模式
    /// </summary>
   sealed class EagerSingleton
    {
        /// <summary>
        /// readonly 限制实例的诞生只能在构造函数或者静态初始化时初始化
        /// </summary>
        private readonly static EagerSingleton eagerSingleton = new EagerSingleton();
        private EagerSingleton(){}

        public EagerSingleton GetEagerSingleton()
        {
            return eagerSingleton;
        }

    }
}
