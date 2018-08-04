using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.进一步强化lambda表达式_编写自己的MyWhere
{
    static class JiHeExt
    {
        //自己编写where扩展方法
        //只有静态类才能写扩展方法，所有集合都实现了IEnumerable接口
        //只要是实现了IEnumerable接口的对象就可以使用foreach遍历（List，数组都实现了此接口）
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> data, Func<T, bool> func)
        {
            //this表示对IEnumerable<T> data作扩展
            List<T> list = new List<T>();
            foreach (T item in data)
            {
                if (func(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
