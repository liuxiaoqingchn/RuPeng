using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> a1 = delegate (int i) { Console.WriteLine(i); };
            a1(3);

            Action<int> a2 = (int i) => { Console.WriteLine(i); };
            a2(666);

            Action<int> a3 = i => Console.WriteLine(i);
            a3(777);

            Func<string, int, bool> f1 = delegate (string s, int i) { return true; };
            bool b= f1("abc", 1);
            Console.WriteLine(b);

            Func<string, int, bool> f2 = (string s, int i) => { return true; };
            Console.WriteLine(f2("ddd",555));

            Func<string, int, bool> f3 = (s, i) => { return true; };
            Func<string, int, bool> f4 = (s, i) => true;


            Console.ReadKey();
        }
    }
}
