using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 内置委托Func和Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Action a1 = new Action(M1);
            a1();

            Action<string,int> a2= new Action<string, int>(M2);
            a2("刘小情", 20);


            Func<string> f1 = new Func<string>(M3);
            string sss = f1();
            Console.WriteLine(sss);

            Func<int, string, int> f2 = new Func<int, string, int>(M4);
            int iii = f2(30, "乐嘉");
            Console.WriteLine(iii);

            Console.ReadKey();
        }

        static void M1()
        {
            Console.WriteLine("没有返回值不带参数");
        }

        static void M2(string s, int i)
        {
            Console.WriteLine("s={0},i={1}",s,i);
        }

        static string M3()
        {
            return "有返回值不带参数";
        }

        static int M4(int i, string s)
        {
            return i + 3;
        }
    }
}
