using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.委托的组合
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDel del1 = new MyDel(F1);
            MyDel del2 = new MyDel(F2);
            MyDel del3 = F3;

            MyDel del4 = del1 + del2 + del3;
            del4(2);

            Console.WriteLine("==================");

            MyDel del5 = new MyDel(F1) + new MyDel(F2) + new MyDel(F3);
            del5(2);

            Console.WriteLine("==================");

            del5 -= del1;
            del5(2);


            Console.ReadKey();

        }

        static void F1(int a)
        {
            Console.WriteLine("F1:"+a);
        }

        static void F2(int a)
        {
            Console.WriteLine("F2:" + a*2);
        }

        static void F3(int a)
        {
            Console.WriteLine("F3:" + a*4);
        }

    }

    delegate void MyDel(int i);
}
