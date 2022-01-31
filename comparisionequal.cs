using System;
using System.Collections.Generic;
using System.Text;

namespace oppsconcept
{
    class comparisionequal
    {
        static void Main4(string[] args)
        {
            string name = "Rajesh";
            string Myname = name;

            var doubleequal = (name == Myname);
            var eql = name.Equals(Myname);
            Console.WriteLine(doubleequal);
            Console.WriteLine(eql);
            Console.WriteLine("====================================");
            object nameObj = "Rajesh";
            char[] values = { 'R', 'a', 'j', 'e', 's', 'h' };
            object myName = new string(values);
            var doubleequal2 = (nameObj == myName);
            var eql2 = nameObj.Equals(myName);
            Console.WriteLine(doubleequal2);
            Console.WriteLine(eql2);
        }
    }

}
