using System;
using System.Collections.Generic;
using System.Text;

namespace Stars
{
    public static class StringExtension
    {
        public static string RemoveEndCharacter(this String s)
        {
            return s.Substring(0, s.Length - 1);
        }
    }
}
