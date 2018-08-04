using MyEx;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密闭类静态类及扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //string e = "aaa.@qq.com";
            //bool b = Person.IsEmail(e);

            //Console.WriteLine(e.IsEmail());

            //string s = "abc";
            //string s1 = Person.Repeat(s, 3);
            //Console.WriteLine(s.Repeat(5));
            //Console.WriteLine(s1);
            //Consoles.WriteLine(b);

            string a = "aaa";
            Console.WriteLine(a.IsEmail());

            SqlConnection conn = new SqlConnection();
            string b= conn.Test("hhh");


            Console.WriteLine(b);
            
            Console.ReadKey();
        }
    }

    /*
    sealed class Dog
    {

    }

    class Bird : Dog
    {

    }

    class A : String
    {

    }
    
    static class Person
    {
        public int Age { get; set; }

        public int age;

        public static string Gender;

        public static string Gender { get; set; }

        public void SayHi()
        {

        }

        public static bool IsEmail()
        {
            return false;
        }
    }
    */

    static class Person
    {
        ////public static bool IsEmail(this string s)
        //{
        //    return s.Contains("@");
        //}

        public static string Repeat(this string s, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += s;
            }
            return result;
        }


    }
   
}
