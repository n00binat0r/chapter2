using System;

namespace Task09
{
    //Декларирайте две променливи от тип string и им присвоете стойност "The "use" of quotations causes difficulties." (без първите и последни кавички).
    //В едната променлива използвайте quoted string, а в другата не го използвайте. 
    class Program
    {
        static void Main(string[] args)
        {
            string unquoted = "The "use" of quotations causes difficulties.";
            string quoted = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(unquoted);
            Console.WriteLine(quoted);
        }
    }
}
