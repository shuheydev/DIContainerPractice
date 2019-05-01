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

            //Aの外でインスタンス化
            var b = new B();
            var c = new C();
            var d = new D();

            //Aのコンスタクタ経由でB、C、Dのインスタンスを渡す
            var a = new A(b, c, d);
            a.Do();

            //インターフェースを実装していさえすればOK
            var bModoki = new BModoki();
            var cModoki = new CModoki();
            var dModoki = new DModoki();

            var a2 = new A(bModoki, cModoki, dModoki);
            a2.Do();
        }
    }


    //クラスB、C、D用のインターフェース
    interface IB
    {
        public void Do();
    }
    interface IC
    {
        public void Do();
    }
    interface ID
    {
        public void Do();
    }

    class A
    {
        private IB _b;
        private IC _c;
        private ID _d;

        public A(IB b, IC c, ID d)
        {
            this._b = b;
            this._c = c;
            this._d = d;
        }

        public void Do()
        {
            this._b.Do();
            this._c.Do();
            this._d.Do();
        }
    }

    class B : IB
    {
        public void Do()
        { }
    }

    class C : IC
    {
        public void Do()
        { }
    }

    class D : ID
    {
        public void Do()
        { }
    }



    class BModoki : IB
    {
        public void Do()
        { }
    }

    class CModoki : IC
    {
        public void Do()
        { }
    }

    class DModoki : ID
    {
        public void Do()
        { }
    }
}
