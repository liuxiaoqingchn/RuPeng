using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _3.Method和Property的主要成员
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取Person对象
            Type type = typeof(Person);

            //使用无参数构造方法创建此类的对象（如果没有无参构造函数会报异常）
            object obj = Activator.CreateInstance(type);//==object obj = new person();

            //获取Name属性
            PropertyInfo propertyName = type.GetProperty("Name");
            //设置Name属性的值为刘小情，==obj.Name="刘小情"
            propertyName.SetValue(obj, "刘小情");

            //和上面同理
            PropertyInfo propertyAge = type.GetProperty("Age");
            propertyAge.SetValue(obj, 22);//obj.Age=22

            //获取SayHi()方法
            MethodInfo methodSayHi = type.GetMethod("SayHi", new Type[0]);
            //在obj指定的对象上调用SayHi()方法  ==obj.SayHi()
            methodSayHi.Invoke(obj, new object[0]);

            //获取SayHi(string name)方法
            MethodInfo methodSayHi2 = type.GetMethod("SayHi", new Type[] { typeof(string) });
            //在obj指定的对象上调用SayHi(string name)方法  ==obj.SayHi("孙杨")
            methodSayHi2.Invoke(obj, new object[] { "孙杨" });

            //获取SayHi(string name,int age)方法
            MethodInfo methodSayHi3 = type.GetMethod("SayHi", new Type[] { typeof(string), typeof(int) });
            //在obj指定的对象上调用SayHi(string name,int age)方法  ==obj.SayHi("成龙"，56)
            methodSayHi3.Invoke(obj, new object[] { "成龙", 56 });

            Console.ReadKey();
        }
    }

    class Person : Program
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
            Console.WriteLine("name="+name);
        }

        public void SayHi(string name, int age)
        {
            Console.WriteLine(name+"今年"+age+"岁");
        }
    }
}
