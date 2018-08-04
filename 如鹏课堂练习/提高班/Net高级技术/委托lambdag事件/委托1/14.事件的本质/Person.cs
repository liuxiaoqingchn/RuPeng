using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.事件的本质
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
                    _OnBinMingNian();
                }
            }
        }

        private Action _OnBinMingNian;
        public event Action OnBinMingNian
        {
            add
            {
                this._OnBinMingNian += value;
            }

            remove
            {
                this._OnBinMingNian -= value;
            }
        }

    }
}
