﻿namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Jane";

            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");

            string name = "Jane";
            ushort age = 27;
            bool havePet = true;
            float footSize = 78.5F;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("Do you have a pet? " + havePet);
            Console.WriteLine("My foot size is " + footSize);

        }
    }
}
