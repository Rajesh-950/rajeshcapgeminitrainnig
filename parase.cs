using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class parase
    {
        public static void main2(string[] args)
        {
            Console.WriteLine("enter  input");
            int num = Convert.ToInt32(Console.ReadLine());
            bool result = int.TryParse("num", out num);
            Console.WriteLine(result);
            if (result==true)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Not an Integer");
            }
            
        }

    }
}
