using System;

namespace ConsoleApp2
{
   class Program
    {
        public static void sum(int a, int b)
        {
            Console.WriteLine("a+b=" + (a + b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("a-b=" + (a - b));
        }
        public static void multiplication(int a, int b)
        {
            Console.WriteLine("a*b=" + (a * b));
        }
        public bool Palindrome(string str)
        {
            int end = str.Length - 1;

            for (int i = 0, j = end; i < end; i++, j--)
            {
                char frontLetter = str[i];	//Char.ToLower(str[i]);
                char endLetter = str[j];	//Char.ToLower(str[i]);

                if (frontLetter != endLetter) return false;
            }
            return true;
        }
        static int N = 4;

        
        static void add(int[,] A, int[,] B, int[,] C)
        {
            int i, j;
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                    C[i, j] = A[i, j] + B[i, j];
        }

        static void Main(string[] args)
        {
            int a1 = 10;
            object b1 = a1;
            int c = (int)b1;
            Console.WriteLine(b1);
            Console.WriteLine(a1);
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            /*for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }*/
            Console.WriteLine("Enter any two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            sum(a, b);
            sub(a, b);
            multiplication(a, b);
            //palindrome

            Console.WriteLine(new Program().Palindrome("mom"));

            int[,] A = { {1, 1, 1, 1},
                        {2, 2, 2, 2},
                        {3, 3, 3, 3},
                        {4, 4, 4, 4}};

            int[,] B = { {1, 1, 1, 1},
                        {2, 2, 2, 2},
                        {3, 3, 3, 3},
                        {4, 4, 4, 4}};

           
           int[,] C = new int[N, N];
            int i, j;
            add(A, B, C);
            Console.WriteLine("matrix A=");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                    Console.Write(A[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("matrix B=");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                    Console.Write(B[i, j] + " ");
                Console.WriteLine();
            }


            Console.WriteLine("Result matrix is ");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                    Console.Write(C[i, j] + " ");
                Console.WriteLine();
            }
            int[,] samplearray1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] samplearray2 = new int[2, 2] { { 1, 0}, { 3, 4 } };
            int[,] samplearray3 = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            /*for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    samplearray3[i, j] = 0;
                    for (int x=0; x<samplearray2.Length; x++)
                    {
                        samplearray3[i, j] = samplearray1[i,j] * samplearray2[i,j];
                    }

                }
            }*/
           
            }

        }
    }

    

