using Prism.Ioc;
using System;
using System.Collections.Generic;
using Unity;
using Unity.Injection;


namespace DIContainerPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    class A
    {
        public void Do()
        {
            var b = new B();
            var c = new C();
            var d = new D();

            b.Do();
            c.Do();
            d.Do();
        }
    }

    class B
    {
        public void Do()
        { }
    }

    class C
    {
        public void Do()
        { }
    }

    class D
    {
        public void Do()
        { }
    }

}
