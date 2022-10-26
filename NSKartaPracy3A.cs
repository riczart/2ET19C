using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaPracy3A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            
             *            WSTEP PRZYKLADY
             *            int n = int.Parse(Console.ReadLine());
                        for (int i = 1; i < n + 1; i++)
                        {
                            for (int j = 1; j < n + 1; j++)
                            {
                                if (n - j < i) Console.Write("*");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }*/

            /*            int n = int.Parse(Console.ReadLine());
                        for (int i = 1; i < n + 1; i++)
                        {
                            for (int j = 1; j < n + 1; j++)
                            {
                                if (n - i < j) Console.Write("*");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }*/

            /*            zad 7
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 1; i < n+1; i++)
                        {
                            for (int j = 1; j < n+1; j++)
                            {
                                if (i == 1 || j == 1 || i == n || j == n || (i == n/2 + 1 && j == n/2 + 1)) Console.Write("*");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }*/

            /*            zad 7
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 1; i < n + 1; i++)
                        {
                            for (int j = 1; j < n + 1; j++)
                            {
                                if (i == n-j+1) Console.Write("?");
                                else if (i == j) Console.Write("*");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }*/

            /*            zad 5
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 1; i < n + 1; i++)
                        {
                            for (int j = 1; j < n + 1; j++)
                            {
                                if (j == n / 2 + 1) Console.Write("*");
                                else if (i == n / 2 + 1) Console.Write("-");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();*/

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i + j == n/2 + 2) Console.Write("?");
                    else if (i == j) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
