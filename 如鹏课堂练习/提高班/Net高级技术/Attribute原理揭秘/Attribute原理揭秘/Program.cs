using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attribute原理揭秘
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = Guid.NewGuid();
            p.Name = "刘小情";
            p.Age = 22;

            Type t = p.GetType();

            //获取type上标注的ObsoleteAttribute
            object[] obsoletes = t.GetCustomAttributes(typeof(ObsoleteAttribute), false);
            if (obsoletes.Length > 0)
            {
                Console.WriteLine("此类已过时");
            }
            else
            {
                Console.WriteLine("此类没有过时");
            }

            Console.WriteLine("================================");
            foreach (PropertyInfo item in t.GetProperties())
            {
                //获得属性名称
                string name = item.Name;

                #region DisPlayNameAttribute

                //获得item上标注的DisPlayNameAttribute类型的Attribute对象
                DisplayNameAttribute displayNameAtt = (DisplayNameAttribute)item.GetCustomAttribute(typeof(DisplayNameAttribute));

                string displayName = string.Empty;
                if (displayNameAtt == null)//如果为空就没有标注这样一个Attribute
                {
                    displayName = null;
                }
                else
                {
                    //获得displayattribute对象的DisPalyName的值
                    displayName = displayNameAtt.DisplayName;
                }
                #endregion

                JPAttribute jPAttribute = (JPAttribute)item.GetCustomAttribute(typeof(JPAttribute));

                string jpName = string.Empty;

                if (jPAttribute == null)
                {
                    jpName = "无";
                }
                else
                {
                    jpName = jPAttribute.DispayName;
                }


                //获得属性名的值
                object value = item.GetValue(p);
                Console.WriteLine(name + "(" + displayName + ")"+"(日文:"+jpName+")="+ value);

            }




            Console.ReadKey();
        }
    }

    [Obsolete]//弃用的类，已过时
    class Person
    {
        [JP("アイテム")]
        [DisplayName("编号")]
        public Guid Id { get; set; }

        [JP("なまえ")]
        [DisplayName("姓名")]
        public string Name { get; set; }

        [DisplayName("年龄")]
        public int Age { get; set; }
        public void SayHi()
        {
            Console.WriteLine("id:{0},name:{1},age:{2}", Id, Name, Age);
        }
    }
}
