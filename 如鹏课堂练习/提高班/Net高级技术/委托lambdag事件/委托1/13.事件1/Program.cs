using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.事件1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.OnBinMingNian += BMN;//监听事件
            p.OnBinMingNian += BMN2;
            p.Age = 5;
            Console.WriteLine(p.Age);
            p.Age = 24;
            Console.WriteLine(p.Age);
            p.Age = 55;
            Console.WriteLine(p.Age);
            p.Age = 48;
            Console.WriteLine(p.Age);

            Console.ReadKey();
        }

        static void BMN()
        {
            Console.WriteLine("到了本命年");
        }

        static void BMN2()
        {
            Console.WriteLine("到了本命年2");
        }

    }
}
