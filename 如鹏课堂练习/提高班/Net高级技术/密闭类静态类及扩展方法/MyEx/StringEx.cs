using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEx
{
    //扩展方法所在的类必须是static类
    //扩展方法的第一个参数类型是被扩展的类型，类型前面标注为this
    public static class StringEx
    {
        public static bool IsEmail(this string s)
        {
            return s.Contains("@");
        }
        
        public static string Test(this SqlConnection connection, string sql)
        {
            return "执行成功";
        }

    }
}
