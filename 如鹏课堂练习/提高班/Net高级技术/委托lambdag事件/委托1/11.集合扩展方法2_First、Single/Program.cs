using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.集合扩展方法2_First_Single
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = { };
            string[] s2 = { "a"};
            string[] s3 = { "a","b"};

            //Console.WriteLine(s1.First());//抛异常
            //Console.WriteLine(s2.First());//a
            //Console.WriteLine(s3.First());//a

            //Console.WriteLine(s1.FirstOrDefault());//不抛异常，返回变量类型的默认值
            //Console.WriteLine(s2.FirstOrDefault());//a
            //Console.WriteLine(s3.FirstOrDefault());//a


           // Console.WriteLine(s1.Single()); //抛异常
           // Console.WriteLine(s2.Single());//a
           // Console.WriteLine(s3.Single());//抛异常


            //Console.WriteLine(s1.SingleOrDefault()); //不抛异常，返回变量类型的默认值
            //Console.WriteLine(s2.SingleOrDefault());//a
            //Console.WriteLine(s3.SingleOrDefault());//抛异常


            //因为where,orderBy,select返回的均是IEnumerable类型，所以可以一直点下去
            int[] nums = { 1,2,5,7,5};
            foreach (int item in nums.Where(abc=>abc>3).OrderBy(q=>q))
            {
                //Console.WriteLine(item);
            }

            Console.WriteLine(nums.Where(abc => abc > 3).OrderBy(q => q).FirstOrDefault());
            Console.WriteLine("===========================");
            Console.WriteLine(nums.Where(abc => abc > 3).OrderBy(q => q).Select(a=>a*2).FirstOrDefault());

            Console.ReadKey();

        }
    }
}
