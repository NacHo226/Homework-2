using System;

namespace type_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var overload = new overload();
            overload.Display();
        }
    }

    class overload
    {
        public void Display()
        {
            DisplayOverload(100, "Akhil", "Mittal", "OOP");
            DisplayOverload(200, "Akhil");
            DisplayOverload(300);
        }

        void DisplayOverload(int a, params string[] parameterArray)
        {
            {
                foreach (string str in parameterArray) 
                    Console.WriteLine(str + " " + a);
            }
        }
    }
}