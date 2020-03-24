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

            var container = new UnityContainer();

            //型引数にはインターフェースとその具象クラスをペアで指定
            //そのインターフェースの引数には、ペアとなる具象クラスのインスタンスを使う、
            //という指定。
            container.RegisterType<IB, BModoki>();//BModoki
            container.RegisterType<IC, C>();
            container.RegisterType<ID, D>();

            //クラスBModoki、C、Dのインスタンスを生成し、
            //クラスAのコンストラクタに渡して、
            //クラスAのインスタンスを生成
            var a = container.Resolve<A>();
            a.Do();

            //クラスAのインスタンス生成は1行でOK
            var aa = container.Resolve<A>();
            var aaa = container.Resolve<A>();
            var aaaa = container.Resolve<A>();
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

        public A(IB b, IC c, ID d,string text)
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
