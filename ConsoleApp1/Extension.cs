using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Extension
    {
        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value);
        }
    }
}
