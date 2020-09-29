using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = 0;
                Console.Write("Enter a number(>1), enter 0 to quit:");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                else if (n <= 1)
                {
                    continue;
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        int width = 2 * n - 2 + 2 * i;
                        int space = Math.Abs(n - 1 - i);
                        for(int s = 0; s<space; s++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= width; j++)
                        {
                            if (i != 0)
                            {
                                if (j == 0 || j == width)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        Console.Write("\n");
                        
                    }
                    for (int i = n - 2; i >= 0; i--)
                    {
                        int width = 2 * n - 2 + 2 * i;
                        int space = Math.Abs(n - 1 - i);
                        for (int s = 0; s < space; s++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= width; j++)
                        {
                            if (i != 0)
                            {
                                if (j == 0 || j == width)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        Console.Write("\n");

                    }


                }
            }
        }
    }
}

