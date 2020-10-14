using System;

namespace Task04
{
    //4. Инициализирайте променлива от тип int със стойност 256 в шестнадесетичен формат (256 е 100 в бройна система с основа 16). 

    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 0x100;
            Console.WriteLine(myInt);
        }
    }
}
