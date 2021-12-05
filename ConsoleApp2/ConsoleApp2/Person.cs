using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Person
    {
        protected int age;

        public void Greet() 
        {
            Console.WriteLine("Hi");

        }
        public void SetAge(int n)
        {
            age = n;
        }

    }
}
