using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.lambda改造GetMax方法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, 8, 14, 9 };

            //以下步骤进行推演，逐渐简化
            //1:
            Func<int, int, bool> f = delegate (int i1, int i2) { return i1 > i2; };
            int max = GetMax(nums, f);
            Console.WriteLine(max);

            //2:
            int max2 = GetMax(nums, delegate (int i1, int i2) { return i1 > i2; });
            Console.WriteLine(max2);

            //3:
            int max3 = GetMax(nums, (int i1, int i2) => { return i1 > i2; });
            Console.WriteLine(max3);

            //4:
            int max4 = GetMax(nums, (i1, i2) => { return i1 > i2; });
            Console.WriteLine(max4);

            //5:
            int max5 = GetMax(nums, (i1, i2) => i1 > i2);
            Console.WriteLine(max5);


            Person[] persons = new Person[]
            {
                new Person("百度", 5),
                new Person("腾讯", 8),
                new Person("如鹏", 4)
            };
            Person p = GetMax(persons, (p1, p2) => p1.Age > p2.Age);
            Console.WriteLine(p);

            Console.ReadKey();
        }

        static T GetMax<T>(T[] objs, Func<T, T, bool> compareFunc)
        {
            T max = objs[0];
            for (int i = 0; i < objs.Length; i++)
            {
                if (compareFunc(objs[i], max))
                {
                    max = objs[i];
                }
            }
            return max;
        }

    }

}
