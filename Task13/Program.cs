using System;

namespace Task13
{
    //13. Декларирайте две променливи от тип int. Задайте им стойности съответно 5 и 10. Разменете стойностите им и ги отпечатайте. 
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c;
            c = b;
            b = a;
            a = c;

            Console.WriteLine("A = "+a+" B = "+b);
        }
    }
}
