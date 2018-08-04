using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.事件的本质
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.OnBinMingNian += P_OnBinMingNian;

            p.Age = 10;
            Console.WriteLine(p.Age);

            p.Age = 48;
            Console.WriteLine(p.Age);

            Console.ReadKey();
        }

        private static void P_OnBinMingNian()
        {
            Console.WriteLine("本命年");
        }
    }
}
