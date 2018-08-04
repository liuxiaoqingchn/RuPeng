using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 模拟PropertyGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "刘小情";
            p.Age = 22;
            ShowObject(p);

            Console.ReadKey();
        }

        static void ShowObject(object obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] property = t.GetProperties();
            foreach (PropertyInfo item in property)
            {
                if (item.CanRead)
                {
                    string propName = item.Name;
                    Object value = item.GetValue(obj);//获取obj对象的item属性的值
                    Console.WriteLine(propName + "=" + value);
                }
            }
        }
    }

    class Person
    {
        private string gender;
        private int age;
        public Person() { }
        public Person(string name) { }
        public Person(string name, int age) { }
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHi()
        {
            Console.WriteLine("大家好，我是:" + this.Name + ",我的年龄是:" + this.Age);
        }

        public void SayHi(string name)
        {
            Console.WriteLine("name=" + name);
        }

        public void SayHi(string name, int age)
        {
            Console.WriteLine(name + "今年" + age + "岁");
        }
    }
}
