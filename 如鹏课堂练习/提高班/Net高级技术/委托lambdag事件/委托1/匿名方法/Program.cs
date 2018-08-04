using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] nums = new object[] { 1, 8, 4, 6, 0 };
            //object max= GetMax(nums, CompareInt);
            //Console.WriteLine(max);

            //用匿名方法改造
            CompareFunc func = delegate (object obj1, object obj2)
              {
                  int n1 = (int)obj1;
                  int n2 = (int)obj2;
                  return n1 > n2;
              };

            object max = GetMax(nums, func);
            Console.WriteLine(max);


            CompareFunc2 func2 = delegate (string a, string b, int c)
              {
                  return a + b + c;
              };




            Console.ReadKey();
        }

        static bool CompareInt(object i1, object i2)
        {
            int n1 = (int)i1;
            int n2 = (int)i2;
            return n1 > n2;
        }

        static object GetMax(object[] nums, CompareFunc func)
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (func(nums[i], max))
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }

    //如果obj1大于obj2,返回true，否则返回false
    delegate bool CompareFunc(object obj1, object obj2);
    delegate string CompareFunc2(string s1, string s2, int i);
}
