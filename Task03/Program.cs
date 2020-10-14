using System;

namespace Task03
{
    //3. Напишете програма, която сравнява вярно две реални числа с точност до 0.000001
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сравнение на числа с точност до 0.0000001");
            Console.WriteLine("Enter 1st number");
            string string1 = (Console.ReadLine());
            float num1 = (float)Convert.ToDouble(string1);
            Console.WriteLine("Enter 2nd number");
            string string2 = (Console.ReadLine());
            float num2 = (float)Convert.ToDouble(string2);
            /* if (num1 > num2)
             {
                 Console.WriteLine(num1 + " is larger");
             }
             else if (num2 > num1)
             {
                 Console.WriteLine(num2 + " is larger");
             }
             else
             {
                 Console.WriteLine("numbers are equal");
             }*/
            bool equal = Math.Abs(num1 - num2) < 0.000001;
            Console.WriteLine("are numbers equal: " + equal);
        }
    }
}
