using System;
using System.Collections.Generic;
using System.Text;

namespace oppsconcept
{
    class objectClass
    {
        static void Main3(string[] args)
        {
            

            object Obj1 = new object();
            object Obj2 = new object();
            int i = 10;

            bool result = Equals(Obj1, Obj2);
            Console.WriteLine(result);
            Type t1 = Obj1.GetType();
            Type t2 = i.GetType();
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.Namespace);
            Console.WriteLine(t1.BaseType);
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.Namespace);
            Console.WriteLine(t2.BaseType);

        }
    }
}
