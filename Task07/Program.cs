using System;

namespace Task07
{
    //7. Декларирайте две променливи от тип string със стойности "Hello" и "World". Декларирайте променлива от тип object. 
    //Присвоете на тази променлива стойността, която се получава от конкатенацията на двете стрингови променливи (добавете интервал, ако е необходимо). Отпечатайте променливата от тип object. 
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            object myObject = string1 + " " + string2;
            Console.WriteLine(myObject);
        }
    }
}
