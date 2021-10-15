using System;

namespace type_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.Display();
        }
    }

    class Overload
    {
        public void Display()
        {
            DisplayOverload(100, "200", "300");
            DisplayOverload(200, "100");
            string[] names = {"Akhil", "Ekta", "Arsh"};
            DisplayOverload(200, names);
        }

        void DisplayOverload(int a, params string[] parameterArray)
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }
    }
}