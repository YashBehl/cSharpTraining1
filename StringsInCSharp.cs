using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Abcd efGh xyz";

            //string methods
            Console.WriteLine(s.Length + " is length of string");
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(string.Concat(s, "pqr"));
            Console.WriteLine(s[3] + " is 4th character in string");
            Console.WriteLine(s.IndexOf("f"));
            Console.WriteLine(s.Substring(s.IndexOf("x")));


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //stringbuilder and its functions
            StringBuilder strg = new StringBuilder("abcd efgd", 25);
            Console.WriteLine(strg);

            strg.Append(" xyz");
            strg.AppendLine("pqrs");
            Console.WriteLine(strg);

            strg.Insert(10, "mnop");
            Console.WriteLine(strg);

            strg.Remove(6, 5);
            Console.WriteLine(strg);

            strg.Replace("xyz", "rst");
            Console.WriteLine(strg);

            Console.ReadKey();
        }
    }
}
