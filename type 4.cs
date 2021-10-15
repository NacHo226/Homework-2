using System;

namespace type_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.Display();
        }
    }

    public class Overload
    {
        public void Display()
        {
            int[] numbers = {10, 20, 20};
            DisplayOverload(40, numbers);
            Console.WriteLine(numbers[1]);
        }

        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }
    }
}