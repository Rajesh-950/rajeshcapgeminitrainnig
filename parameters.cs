using System;
using System.Collections.Generic;
using System.Text;

namespace oppsconcept
{
    class parameters
    {
        static void Main5(string[] args)
        {
            sample(3, 2);
            namedp(x: 3, z: 4, y: 2);

        }
        public static void sample(int x = 10, int y = 20, int z = 30)
        {
            Console.WriteLine("{0},{1},{2}", x, y, z);
        }
        public static void namedp(int x = 10, int y = 20, int z = 30)
        {
            Console.WriteLine("{0},{1},{2}" ,x, y, z);
        }
    }
}
