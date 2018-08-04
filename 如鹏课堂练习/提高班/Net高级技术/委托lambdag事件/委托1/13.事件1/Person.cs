using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.事件1
{
    class Person
    {
        private int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
                if (age % 12 == 0)
                {
                    OnBinMingNian();//调用添加组合的方法
                }
            }
        }

        /// <summary>
        /// 定义事件（event 委托类型 事件名）
        /// </summary>
        public event Action OnBinMingNian;
        //public Action OnBinMingNian;  不加event就是普通的委托，加event就是事件
    }
}
