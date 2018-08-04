using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.反射1
{
    class Program
    {
        public override string ToString()
        {
            return "我是Program";
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            //获取对象的三种方法
            Type t = p.GetType();
            Type t1 = typeof(Program);
            Type t2 = Type.GetType("_1.反射1.Program");

            Console.WriteLine(t);
            Console.WriteLine(t1);
            Console.WriteLine(t2);

            //调用无参构造函数，动态创建对象
            //动态创建类，类必须有public且无参构造函数
            //使用无参数构造方法创建此类的对象（如果没有无参构造函数会报异常）
            object obj = Activator.CreateInstance(t);//动态创建t1指向的类的对象，相当于new Person();
            Console.WriteLine("对象："+obj);


            Child c = new Child();
            c.Hello();

            Child2 c1 = new Child2();
            c1.Hello();

            Console.ReadKey();
        }

        
    }
    class Parent
    {
        public void Hello()
        {
            //this:不是“当前类”,而是“当前对象”
            Type t = this.GetType();
            Console.WriteLine(t);
        }
    }

    class Child : Parent
    {

    }

    class Child2 : Parent
    {

    }

}
