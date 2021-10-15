using System;

namespace type_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.Display1();
        }
    }

    class ClassA : ClassB { }

    class ClassB
    {
        public int x = 100;

        public void Display1()
        {
            Console.WriteLine("ClassB Display1");
        }

        public void Display2()
        {
            Console.WriteLine("ClassB Display2");
        }
    }   
    
}