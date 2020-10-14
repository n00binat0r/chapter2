using System;

namespace Task01
{
    //1. Декларирайте няколко променливи, като изберете за всяка една найподходящия от типовете sbyte, byte, short, ushort, int, uint, long и ulong, за да им присвоите следните стойности: 52130, -115, 4825932, 97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990; 123456789123456789
    class Program
    {
        static void Main(string[] args)
        {
            ushort short1 = 52130;
            sbyte byte1 = -115;
            int int1 = 4825932;
            byte byte2 = 97;
            short short2 = -10000;
            ushort short3 = 20000;
            byte byte3 = 224;
            int int2 = 970700000;
            byte byte4 = 112;
            sbyte byte5 = -44;
            int int3 = -1000000;
            short short4 = 1990;
            ulong long1 = 123456789123456789;
            string s;
            Console.WriteLine("{0} {1}",short1, byte1);
        }
    }
}
