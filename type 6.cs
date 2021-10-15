using System;

namespace type_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();
            classB.XXX();
        }
    }

    public class ClassA
    {
        public virtual void XXX()
        {
            Console.WriteLine("ClassA XXX");
        }
    }

    public abstract class ClassB : ClassA
    {
        public new abstract void XXX();
    }

    public class ClassC : ClassB
    {
        public override void XXX()
        {
            Console.WriteLine("ClassC xxx");
        }
    }
}