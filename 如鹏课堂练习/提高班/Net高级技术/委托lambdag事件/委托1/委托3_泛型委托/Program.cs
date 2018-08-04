using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托3_泛型委托
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums= new int[] { 1,5,9,4,10,8};
            int max = GetMax(nums, CompareInt);//或 int max = GetMax<int>(nums, CompareInt);
            Console.WriteLine(max);

            string[] strs = { "1","3"};
            string max2 = GetMax<string>(strs, CompareString);
            Console.WriteLine(max2);
            Console.ReadKey();
        }

        static bool CompareInt(int i1, int i2)
        {
            return i1 > i2;
        }

        static bool CompareString(string s1, string s2)
        {
            return int.Parse(s1) > int.Parse(s2);
        }

        static T GetMax<T>(T[] nums, CompareFunc<T> func)
        //GetMax<int>
        // static int GetMax<int>(int[] nums, CompareFunc<int> func)
        {
            T max = nums[0];
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

    delegate bool CompareFunc<T>(T obj1, T obj2);
}
