using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.进一步强化lambda表达式_编写自己的MyWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 8,9,4,6,1};
            IEnumerable<int> a1 = nums.MyWhere(n => n > 6);//delegete(int n){return n>6;}
            foreach (int item in a1)
            {
                //Console.WriteLine(item);
            }

            
            foreach (int item in nums.MyWhere(n => n % 2 == 0))//delegate(int n){ return n % 2 == 0;}
            {
                Console.WriteLine(item);
            }

            string[] strs = new string[] { "tom","jim","steven"};
            IEnumerable<string> a2 = strs.MyWhere(s=>s.Contains("m"));
            foreach (string item in a2)
            {
                Console.WriteLine(item);
            }

            foreach (string item in strs.MyWhere(s=>s.Length==6))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
