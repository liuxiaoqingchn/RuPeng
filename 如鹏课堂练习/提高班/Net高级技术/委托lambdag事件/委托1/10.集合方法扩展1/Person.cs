using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.集合方法扩展1
{
    class Person
    {
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
            
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Name:" + Name + "  Age:" + Age;
        }
    }
}
