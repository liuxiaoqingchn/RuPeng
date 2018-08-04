using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDel del = new MyDel(F1);            
            Console.WriteLine(del(10));

            MyDel2 del2 = new MyDel2(F2);
            del2("美国", "德国");

            Mydel3 mydel3 = new Mydel3(F3);
            Mydel3 mydel4 = F3;//等价于Mydel3 mydel4 = new Mydel3(F3);
            string s = mydel4();
            Console.WriteLine(s);

            Console.ReadKey();
        }
        static int F1(int num)
        {
            return num;
        }

        static void F2(string s1, string s2)
        {
            Console.WriteLine("s1={0},s2={1}",s1,s2);
        }

        static string F3()
        {
            return "abc";
        }

    }
    delegate void MyDel2(string str1, string str2);
}
