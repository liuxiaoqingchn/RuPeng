using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute原理揭秘
{
    /// <summary>
    /// 显示日文标签
    /// </summary>
    class JPAttribute:Attribute
    {
        public string DispayName { get; set; }
        public JPAttribute(string value)
        {
            this.DispayName = value;
        }
    }
}
