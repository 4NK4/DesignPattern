using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉式单例模式
    /// </summary>
    class LazySingleton
    {
        private LazySingleton lazySingleton;
        private LazySingleton() { }

        readonly static Object obj = new object();//限制只在静态初始化时 obj有实例

        public LazySingleton GetLazySingleton()
        {
            if(lazySingleton==null)//这里线程不安全
            {
                lock (obj)//当两者同时到此,但是都没有初始化,且是排队的,但这时会有一个进去初始化成功,但是下一个也会进去,因此还需要一层判断,即前者是否初始化成功了
                {
                    if (lazySingleton != null) return lazySingleton;
                    lazySingleton = new LazySingleton();
                    return lazySingleton;
                }

            }
            return lazySingleton;
        }


        

    }
}
