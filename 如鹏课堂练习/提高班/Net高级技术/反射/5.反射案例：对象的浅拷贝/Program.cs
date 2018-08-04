using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _5.反射案例_对象的浅拷贝
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "liuxiaoqing";
            p1.Age = 22;

            Person p2 = (Person)MyClone(p1);
            p2.SayHi();

            Console.ReadKey();
        }

        /// <summary>
        /// 创建对象的一份拷贝
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        static object MyClone(object obj)
        {
            Type type = obj.GetType();
            Object newObj = Activator.CreateInstance(type);
            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (prop.CanRead && prop.CanWrite)
                {
                    object value = prop.GetValue(obj);//获取obj对象的属性的值
                    prop.SetValue(newObj,value);//把值赋值给newobj对应的属性
                }
            }
            return newObj;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHi()
        {
            Console.WriteLine("大家好，我是:" + this.Name + ",我的年龄是:" + this.Age);
        }
    }
}
