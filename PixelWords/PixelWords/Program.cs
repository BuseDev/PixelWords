using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 4]
            {
              {0,1,1,0},{1,0,0,1},{1,1,1,1},{1,0,0,1},{1,0,0,1}
            };

            int[,] B = new int[5, 4]
            {
                {1,1,1,0},{1,0,0,1},{1,1,1,0},{1,0,0,1 },{1,1,1,0}
            };
            int[,] C = new int[5, 4]
            {
                {0,1,1,1},{1,0,0,0},{1,0,0,0},{1,0,0,0},{0,1,1,1}
            };
            int[,] D = new int[5, 4]
            {
                {1,1,1,0},{1,0,0,1},{1,0,0,1},{1,0,0,1},{1,1,1,0}
            };
            int[,] E = new int[5, 4]
            {
                {1,1,1,1},{1,0,0,0},{1,1,1,0},{1,0,0,0},{1,1,1,1}
            };
            int[,] F = new int[5, 4]
            {
                {1,1,1,1},{1,0,0,0},{1,1,1,0},{1,0,0,0},{1,0,0,0}
            };
            int[,] G = new int[5, 4]
            {
                {0,1,1,1},{1,0,0,0},{1,0,1,1},{1,0,0,1},{0,1,1,1}
            };
            int[,] H = new int[5, 4]
            {
                {1,0,0,1},{1,0,0,1},{1,1,1,1},{1,0,0,1},{1,0,0,1}
            };
            int[,] I = new int[5, 3]
            {
                {0,1,0},{0,1,0},{0,1,0},{0,1,0},{0,1,0}
            };
            int[,] J = new int[5, 4]
            {
                {0,0,0,1},{0,0,0,1},{0,0,0,1},{1,0,0,1},{0,1,1,0}
            };
            int[,] K = new int[5, 4]
            {
                {1,0,0,1},{1,0,1,0},{1,1,0,0},{1,0,1,0},{1,0,0,1}
            };
            int[,] L = new int[5, 4]
            {
                {1,0,0,0},{1,0,0,0},{1,0,0,0},{1,0,0,0},{1,1,1,1}
            };
            int[,] M = new int[5, 5]
            {
                {1,0,0,0,1},{1,1,0,1,1},{1,0,1,0,1},{1,0,0,0,1},{1,0,0,0,1}
            };
            int[,] N = new int[5, 4]
            {
                {1,0,0,1},{1,1,0,1},{1,0,1,1},{1,0,0,1},{1,0,0,1}
            };
            int[,] O = new int[5, 4]
            {
                {0,1,1,0},{1,0,0,1},{1,0,0,1},{1,0,0,1},{0,1,1,0}
            };
            int[,] P = new int[5, 4]
            {
                {1,1,1,0},{1,0,0,1},{1,1,1,0},{1,0,0,0},{1,0,0,0}
            };
            int[,] Q = new int[5, 4]
            {
                {0,1,1,0},{1,0,0,1},{1,0,0,1},{1,0,1,1},{0,1,1,1}
            };
            int[,] R = new int[5, 4]
            {
                {1,1,1,0},{1,0,0,1},{1,1,1,0},{1,0,1,0},{1,0,0,1}
            };
            int[,] S = new int[5, 4]
            {
                {0,1,1,1},{1,0,0,0},{0,1,1,0},{0,0,0,1},{1,1,1,0}
            };
            int[,] T = new int[5, 3]
            {
                {1,1,1},{0,1,0},{0,1,0},{0,1,0},{0,1,0}
            };
            int[,] U = new int[5, 4]
            {
                {1,0,0,1},{1,0,0,1},{1,0,0,1},{1,0,0,1},{1,1,1,1}
            };
            int[,] V = new int[5, 3]
            {
                {1,0,1},{1,0,1},{1,0,1},{1,0,1},{1,1,1}
            };
            int[,] W = new int[5, 5]
            {
                {1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{1,0,1,0,1},{0,1,0,1,0}
            };
            int[,] X = new int[5, 3]
            {
                {1,0,1},{1,0,1},{0,1,0},{1,0,1},{1,1,1}
            };
            int[,] Y = new int[5, 3]
            {
                {1,0,1},{1,0,1},{1,1,1},{0,1,0},{0,1,0}
            };
            int[,] Z = new int[5, 4]
            {
                {1,1,1,1},{0,0,0,1},{0,0,1,0},{0,1,0,0},{1,1,1,1}
            };

            Console.WriteLine("Please write a uppercase word");
            string word = Console.ReadLine();
            char[] separate = new char[10];
            separate = word.ToCharArray();
            for (int j = 0; j < 5; j++)
            {
                foreach (char i in separate)
                {
                    if (i == 'A')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (A[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'B')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (B[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'C')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (C[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'D')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (D[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'E')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (E[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'F')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (F[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'G')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (G[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'H')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (H[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'I')
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (I[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'J')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (J[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'K')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (K[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'L')
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (L[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'M')
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if (M[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'N')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (N[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'O')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (O[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'P')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (P[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'Q')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (Q[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'R')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (R[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'S')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (S[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'T')
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (T[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'U')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (U[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'V')
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (V[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'W')
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if (W[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'X')
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (X[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'Y')
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (Y[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == 'Z')
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (Z[j, k] == 0)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.Write(" ");

                    }
                    else if (i == ' ')
                    {
                        Console.Write("  ");

                    }


                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
