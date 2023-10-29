using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_2.Task_1
{
    public static class StringExtension
    {
        public static int CheckIndex(this string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.') return i;
            }
            return -1;
        }
    }
}
