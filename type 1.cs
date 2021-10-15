using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading",100);
        }
    }
}

class Overload
{
    public void DisplayOverload(int a)
    {
        Console.WriteLine($"DisplayOverload: {a}");
    }
    public void DisplayOverload(string a)
    {
        Console.WriteLine($"DisplayOverload: {a}");
    }
    public void DisplayOverload(string a,int b)
    {
        Console.WriteLine($"DisplayOverload: {a} {b}");
    }
}