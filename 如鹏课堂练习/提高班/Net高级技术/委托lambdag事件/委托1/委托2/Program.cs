using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] obj ={ 4, 7, 2, 56 };
            object max= GetMax(obj, CompareInt);
            Console.WriteLine(max);

            string[] obj2 = { "14", "45", "23" };
            Object max2= GetMax(obj2, CompareString);
            Console.WriteLine(max2);

            Person p1 = new Person() { Age = 22, Name = "张三" };
            Person p2 = new Person() { Age = 15, Name = "李四" };
            Person p3 = new Person() { Age = 17, Name = "王五" };
            Person p4 = new Person() { Age = 55, Name = "赵六" };
            Person[] p = new Person[] { p1,p2,p3,p4};
            object max3 = GetMax(p, ComparePerson);
            Console.WriteLine(max3);

            Console.ReadKey();
        }

        static int GetMax(int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        static bool CompareInt(object o1, object o2)
        {
            int n1 = (int)o1;
            int n2 = (int)o2;
            return n1 > n2;
        }

        static bool CompareString(object o1, object o2)
        {
            int n1 = Convert.ToInt32(o1);
            int n2 = Convert.ToInt32(o2);
            return n1 > n2;
        }

        static bool ComparePerson(object o1, object o2)
        {
            Person p1 = (Person)o1;
            Person p2 = (Person)o2;
            return p1.Age > p2.Age;
        }

        //使用委托改造
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

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "姓名：" + Name + "  年龄：" + Age;
        }
    }
}
