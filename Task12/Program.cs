﻿using System;

namespace Task12
//12. Фирма, занимаваща се с маркетинг, иска да пази запис с данни на нейните служители. 
//Всеки запис трябва да има следната характеристика – първо име, фамилия, възраст, пол (‘m’ или ‘f’) и уникален номер на служителя (27560000 до 27569999). 
//Декларирайте подходящи променливи, за да се запази информацията за един служител, като използвате подходящи типове данни и описателни имена. 
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Mario";
            string lName = "Ivanov";
            byte age = 28;
            char sex = 'm';
            uint id = 27560000;
            Console.WriteLine("Name: "+fName+" Surname: "+lName+" Age: "+age+ " sex: "+sex+" ID: "+id);
        }
    }
}
