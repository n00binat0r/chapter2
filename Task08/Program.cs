using System;

namespace Task08
{
    //8. Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World".
    //Декларирайте променлива от тип object и ѝ присвоете стойността на конкатенацията на двете променливи от тип string (не изпускайте интервала по средата).
    //Декларирайте трета променлива от тип string и я инициализирайте със стойността на променливата от тип object. 
    class Program
    {
        static void Main(string[] args)
        {

            string string1 = "Hello";
            string string2 = "World";
            object myObject = string1 + " " + string2;
            string myString =(string) myObject;
            Console.WriteLine(myString); 
        }
    }
}
