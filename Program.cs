using System;

namespace oppsconcept
{
    class Program
    {
        static void Main1(string[] args)
        {
            string sample="Hello";
            object obj = sample;
            string str2 = obj as string;
            Console.WriteLine(str2);
            if (str2 != null)
            {
                Console.WriteLine("Successfully casted");
                Console.WriteLine(str2);
            }
        }
    }
}
