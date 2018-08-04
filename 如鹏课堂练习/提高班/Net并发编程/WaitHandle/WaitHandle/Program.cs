using System;
using System.Threading;

namespace WaitHandle
{
    class Program
    {
        //Set()开门，Reset()关门，WaitOne()等着开门
        static void Main(string[] args)
        {
            //构造函数 false 表示“初始状态为关门”，设置为 true 则初始化为开门状态
            ManualResetEvent mre = new ManualResetEvent(false);
            Thread t1 = new Thread(()=> {
                Console.WriteLine("开始等着开门：");
                mre.WaitOne();
                Console.WriteLine("终于等到你");
            });
            t1.Start();

            Console.WriteLine("按任意键开门：");
            Console.ReadKey();

            mre.Set();
            Console.ReadKey();
        }
    }
}
