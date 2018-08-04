using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jake";
            //char c = name[1];

            Person p = new Person();
            p[3, 5] = "Hello";
            string s = p[1,2];

            Dog d = new Dog();
            d["hello"] = 5;
            int i = d["yeye"];

            Console.WriteLine(i);
            //Console.WriteLine(s);
            Console.ReadKey();
        }

        class Person
        {
            public string this[int x, int y]
            {
                get
                {
                    return "" + x + y;
                }
                set
                {
                    Console.WriteLine("x="+x+"y="+y);
                }
            }
        }

        class Dog
        {
            public int this[string s]
            {
                get
                {
                    return 888;
                }

                set
                {
                    Console.WriteLine("s="+s);
                }
            }
        }

    }
}
