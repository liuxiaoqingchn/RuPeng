using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 把下面的代码尽可能简化
            /*
            1)Action<string, bool> a1 = delegate (string s, bool b)
            {
                if (b) { Console.WriteLine("true" + s); }
                else { Console.WriteLine("false" + s); }
            };
            2)Func<string, int> f1 = delegate (string str) { return Convert.ToInt32(str); }; */


            Action<string, bool> a1 = (s, b) =>
         {
             if (b)
             {
                 Console.WriteLine("true" + s);
             }
             else
             {
                 Console.WriteLine("false" + s);
             }
         };
            a1("刘小情", false);

            Func<string, int> f1 = str => Convert.ToInt32(str);
            Console.WriteLine(f1("45"));
            #endregion
            #region 把下面的代码还原成匿名方法的格式
            Action<string, int> a11 = (s1, i1) => { Console.WriteLine("s1=" + s1 + ",i1=" + i1); };
            Action<string, int> a12 = delegate (string s1, int i1) { Console.WriteLine("s1=" + s1 + ",i1=" + i1); };

            Func<int, string> f12 = n => (n + 1).ToString();
            Func<int, string> f13 = delegate (int n) { return (n + 1).ToString(); };

            Func<int, int> f14 = n => n * 2;
            Func<int, int> f15 = delegate (int n) { return n * 2; };
            #endregion
            #region 写出下面一个lambda表达式的委托类型及非匿名函数格式 n => n > 0;
            Func<int, bool> ff = n => n > 0;
            Console.WriteLine(ff(10));
            #endregion
            Console.ReadKey();
        }
    }
}
