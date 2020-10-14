using System;

namespace Task05
{
    //5. Декларирайте променлива от тип char и присвоете като стойност символа, който има Unicode код 72 (използвайте калкулатора на Windows, за да намерите шестнайсетичното представяне на 72). 
    class Program
    {
        static void Main(string[] args)
        {
            char myChar = '\u0048';
            Console.WriteLine(myChar);
        }
    }
}
