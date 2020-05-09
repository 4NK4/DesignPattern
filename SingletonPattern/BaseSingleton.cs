namespace SingletonPattern
{
    /// <summary>
    /// 静态字段与方法 为类型提供了访问的权限
    /// 而私有化构造方法 则屏蔽了new的访问权限
    /// </summary>
    class BaseSingleton
    {
        private static BaseSingleton baseSingleton;
        private BaseSingleton() { }

        public static BaseSingleton GetBaseSingleton()
        {
            if (baseSingleton == null)
            {
                baseSingleton = new BaseSingleton();
                return baseSingleton;
            }
            return baseSingleton;
        }


    }
}
