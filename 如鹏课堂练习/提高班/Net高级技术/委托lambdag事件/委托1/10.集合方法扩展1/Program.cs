using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.集合方法扩展1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(40);
            list.Add(20);
            list.Add(50);
            list.Add(30);

            Person[] persons = new Person[] { new Person("刘小情", 22), new Person("刘定强", 20), new Person("郑建国", 21) };


            #region where:对数据按照lambda表达式进行过滤
            IEnumerable<int> data = list.Where(i => i > 30);
            foreach (int item in data)
            {
                Console.WriteLine(item);
            }

            foreach (int item in list.Where(a => a > 30))
            {
                Console.WriteLine(item);
            }
            #endregion
            #region seelct:对集合中的数据进行处理，生成一个新的集合(集合的长度和原始长度一样)
            Console.WriteLine("==============================");

            IEnumerable<string> data2 = list.Select(t => "你好:" + t);//delegate(int t) {return "你好:"+t ;};
            foreach (string item in data2)
            {
                Console.WriteLine(item);
            }


            #endregion
            #region max,min,sum,average处理
            Console.WriteLine("==============================");

            int max = list.Max();
            int min = list.Min();
            int sum = list.Sum();
            double avg = list.Average();
            Console.WriteLine(max + "," + min + "," + sum + "," + avg);

            int max2 = persons.Max(m => m.Age);
            int min2 = persons.Min(m => m.Age);
            int sum2 = persons.Sum(s => s.Age);
            double avg2 = persons.Average(a => a.Age);
            Console.WriteLine(max2 + "," + min2 + "," + sum2 + "," + avg2);

            #endregion
            #region orderBy：对数据排序
            Console.WriteLine("==============================");
            //orderBy:升序  OrderByDescending：降序
            foreach (int item in list.OrderBy(i => i))
            {
                Console.WriteLine(item);
            }

            foreach (Person item in persons.OrderByDescending(n => n.Age))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==============================");
            foreach (Person item in persons.OrderBy(p => p.Name.Length))
            {
                Console.WriteLine(item);
            }
            #endregion
            #region ToList,ToArray
            //因为获取到的集合默认返回的是IEnumerable接口类型的数据，但有时我们需要获取的数据是数组或list的，就可以在后面ToList()或ToArray()
            Console.WriteLine("============================");
            List<Person> ps = persons.OrderBy(p => p.Age).ToList();
            Person[] ps1 = persons.OrderBy(p => p.Age).ToArray();
            List<Person> ps3 = persons.ToList();
            Person[] ps4 = persons.ToArray();

            foreach (Person item in ps3)
            {
                Console.WriteLine(item);
            }


            #endregion

            Console.ReadKey();
        }
    }
}
