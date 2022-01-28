using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter value");
            //int numb1 = Convert.ToInt32(Console.ReadLine());
            //int numb2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("input:" + numb1);
            //Console.WriteLine("input2:" + numb2);

            //if (numb1>numb2)
            ///{
            // Console.WriteLine(" num1 is greater than num2");
            //}
            //else
            //{
            //  Console.WriteLine(" num1 is not greater than num2");
            //
            //}

            //int a = 10, b = 5, temp = 0;
            //Console.WriteLine("before swapping a=" + a + "b=" + b);
            //temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("after swapping a="+a + "b=" + b);
            ///Console.WriteLine("Enter age");
            //'int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("age entered=" + age);
            //if(age==18)
            //{
            //  Console.WriteLine("Elgible to vote");

            //}
            //else if(age>60)
            //{
            //   Console.WriteLine("Is a senior citizen");


            // }
            //   else if(age <60 && age>18)
            //{
            //    Console.WriteLine(" elgible to vote");
            //  }
            Console.WriteLine("enter the choice");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 1st input");
            int inp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd input");
            int inp2 = Convert.ToInt32(Console.ReadLine());
            
          
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine(inp1 + inp2);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(inp1 - inp2);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(inp1 * inp2);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(inp1 / inp2);
                        break;
                    }

                default:
                    Console.WriteLine("choose the correct option");
                    break;

            }



        }
    }
}
