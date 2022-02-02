using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab21
{
    internal class Program
    {
        const int n = 2;
        const int m = 5;
        static int[,] pole = new int[n, m] { { 5, 5, 10, 6, 2 }, { 1, 5, 3, 8, 10 } };
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner2();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(pole[i, j] + "");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            Console.ReadKey();
        }

        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (pole[i, j] == 0)
                    {                        
                        pole[i, j] = 1;
                        Thread.Sleep(1);
                    }
                }
            }
        }

        static void Gardner2()
        {
            for (int i = m - 1; i > 0; i--)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    if (pole[j, i] == 0)
                    {                        
                        pole[j, i] = 2;
                            Thread.Sleep(1);
                    }
                }
            }
        }
    }
}

