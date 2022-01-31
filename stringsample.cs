using System;
using System.Collections.Generic;
using System.Text;

namespace oppsconcept
{
    class stringsample
    {
        static void Main(string[] args)
        {
            string s = "value";
            s = "rajesh";
            Console.WriteLine(s);
            s = s.Replace("rajesh", "1,2,3");
            Console.WriteLine("after replacing");
            Console.WriteLine(s);
            var valuearray = s.Split(',');
            Console.WriteLine("Values after spliting");
            for (int i = 0; i < valuearray.Length; i++)
            {
                Console.WriteLine(valuearray[i]);
            }
            StringBuilder sb = new StringBuilder("Rajesh");
            sb.Append("Hello");
            Console.WriteLine(sb);
            Console.WriteLine("+========");

            sb.Replace("Hello", "Hello 1");
            Console.WriteLine(sb);
            sb.Insert(6, "Kumar");
            Console.WriteLine(sb);




        }
    }
}
