using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public static class Util
    {
        public static Boolean IsCharCanInput(Char[] ars, Char one)
        {
            foreach (var right in ars)
            {
                if (right == one) return true;
            }
            return false;
        }
        public static string[] getDefaultEncodings()
        {
            EncodingInfo[] encodings = Encoding.GetEncodings();
            String[] encodenames = new string[encodings.Length];
            int i = 0;
            foreach (var x in encodings)
            {
                encodenames.SetValue(x.Name, i);
                i++;
            }
            Array.Sort(encodenames, new CustomComparer());
            return encodenames;
        }
    }
}
