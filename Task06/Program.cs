using System;

namespace Task06
{
    class Program
    {
        //6. Декларирайте променлива isMale от тип bool и присвоете стойност на последната в зависимост от вашия пол. 
        static void Main(string[] args)
        {
            bool? isMale = null;
            Console.WriteLine("Enter your sex M/F");
            char sex = (char) Console.Read();
            if(sex =='m'){
                isMale = true;
                Console.WriteLine("are you male");
                Console.WriteLine(isMale);
            }
           else if (sex == 'f')
            {
                isMale = false;
                Console.WriteLine("are you male");
                Console.WriteLine(isMale);
            }
            else
            {
                Console.WriteLine("wrong sex");
            }
        }
    }
}
