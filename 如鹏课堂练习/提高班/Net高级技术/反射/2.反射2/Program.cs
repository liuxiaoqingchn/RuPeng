using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _2.反射2
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取当前对象
            Type t1 = typeof(Person);

            Type t2 = t1.BaseType;

            //获取当前对象父类
            Console.WriteLine(t2);


            //String FullName包含命名空间
            Console.WriteLine(t1.FullName);
            //String Name得到类名（不包含命名空间）
            Console.WriteLine(t1.Name);

            Console.WriteLine(t1.IsAbstract);//判断是否是抽象
            Console.WriteLine(t1.IsEnum);//判断是否是枚举
            Console.WriteLine(t1.IsArray);//判断是否是数组

            string[] sss = { "456","789"};
            Type t3 = sss.GetType();
            Console.WriteLine(t3.IsArray);


            //获取参数类型匹配的构造函数
            ConstructorInfo cProgram = t2.GetConstructor(new Type[0]);
            Console.WriteLine(cProgram);

            ConstructorInfo c1 = t1.GetConstructor(new Type[0]);//public Person() { }
            ConstructorInfo c2 = t1.GetConstructor(new Type[] { typeof(string) });// public Person(string name) { }
            ConstructorInfo c3 = t1.GetConstructor(new Type[] { typeof(string), typeof(int) });// public Person(string name, int age) { }
            ConstructorInfo c4 = t1.GetConstructor(new Type[] { typeof(string), typeof(string) });// public Person(string name, string gender) { }
            Console.WriteLine(c1 + "  " + c2 + "  " + c3 + "  " + c4);//c4为null,没有这样的构造函数

            Console.WriteLine("==========================");
            //获得所有的public构造函数,包括父类的
            ConstructorInfo[] c5 = t1.GetConstructors();
            Console.WriteLine(c5.Length);//3
            foreach (ConstructorInfo item in c5)
            {
                Console.WriteLine(item);
            }

            //获取当前对象的所有字段
            Console.WriteLine("=====================");
            FieldInfo[] field = t1.GetFields();//只能获取public字段
            foreach (FieldInfo item in field)
            {
                Console.WriteLine(item);
            }

            //获取当前对象的所有方法
            Console.WriteLine("====================");
            MethodInfo[] methodInfos = t1.GetMethods();
            foreach (MethodInfo item in methodInfos)
            {
                Console.WriteLine(item);
            }

            //获取当前对象的某个方法(如果方法有重载，需要指定第二个参数type[]，否则会报错)
            Console.WriteLine("====================");
            MethodInfo methodInfo = t1.GetMethod("SayHi",new Type[0]);
            MethodInfo methodInfo1 = t1.GetMethod("SayHi", new Type[] { typeof(string)});
            MethodInfo methodInfo2 = t1.GetMethod("SayHi", new Type[] { typeof(string),typeof(int) });
            Console.WriteLine(methodInfo);
            Console.WriteLine(methodInfo1);
            Console.WriteLine(methodInfo2);

            //获取当前对象的所有属性
            Console.WriteLine("====================");
            PropertyInfo[] propertyInfos = t1.GetProperties();
            foreach (PropertyInfo item in propertyInfos)
            {
                Console.WriteLine(item);
            }

            //获取当前对象的某个属性
            Console.WriteLine("====================");
            PropertyInfo propertyInfo = t1.GetProperty("Name");
            Console.WriteLine(propertyInfo);


            Console.ReadKey();
        }
    }

    class Person:Program
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
            Console.WriteLine("大家好，我是:"+this.Name+"我的年龄是:"+this.Age);
        }

        public void SayHi(string name)
        {
            
        }

        public void SayHi(string name,int age)
        {
           
        }
    }
}
