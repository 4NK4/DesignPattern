using System;

namespace BridgePattern
{

    /// <summary>
    /// 桥接模式是:硬件与软件的关系是聚合关系.当遇到这种同级关系时,不要考虑使用继承,这里可能会产生误导,那就是硬件拥有软件,所以软件继承硬件,这是不对的!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Hardware hardware = new Razer();
            hardware.SetHardware(new Calculator());
            hardware.Operation();


            hardware.SetHardware(new Paint());
            hardware.Operation();
            Console.ReadLine();
        }
    }
}
