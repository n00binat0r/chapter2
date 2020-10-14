using System;

namespace Task02
{
    //2. Кои от следните стойности може да се присвоят на променливи от тип float, double и decimal: 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
    class Program
    {
        static void Main(string[] args)
        {
            float float1 = 12.345f;
            float float2 = 8923.1234857f;
            double double1 = 34.567839023;
            decimal decimal1 = 3456.091124875956542151256683467m;
            Console.WriteLine(float1);
            Console.WriteLine(float2);
            Console.WriteLine(double1);
            Console.WriteLine(decimal1);

        }
    }
}
