namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseSingleton c1 = BaseSingleton.GetBaseSingleton();
            BaseSingleton c2 = BaseSingleton.GetBaseSingleton();

            System.Console.WriteLine(c1.Equals(c2));
            System.Console.WriteLine(c1==c2);

            System.Console.ReadLine();
        }
    }







}
