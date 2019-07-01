using System;
using System.Text.RegularExpressions;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            String httpurl1 = "http://api.union.com/";
            //String httpurl2 = "search.123.com/q?w=123";
            //String httpurl12 = "https://apitest.v.com/";
            String sSiteId = Regex.Match(httpurl1, "(?<=website/).*?(?=/zdypage.aspx)").Value;
            string p = @"((http|https)://)(?<!/)";
            Regex reg = new Regex(p, RegexOptions.IgnoreCase);
            Match m = reg.Match(httpurl1);
            string Result = m.Groups["domain"].Value;
            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
