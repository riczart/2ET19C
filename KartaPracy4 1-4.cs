using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy4
{
    internal class Program
    {
        public static int Zad2(int n)
        {
            int suma_cyrf = 0;
            int cyfra;
            while( n > 0 )
            {
                cyfra = n % 10;
                suma_cyrf += cyfra;
                n = n / 10;
            }
            return suma_cyrf;
        }

        public static int Fibo(int n)
        {
            if (n <2)
            {
                return 1;
            }
            return Fibo(n - 1) + Fibo(n - 2);
        }

        /*zad3*/
        public static int Silnia(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n * Silnia(n - 1);
        }


        /*        samodzielny przyklad 
        public static int Ankieta(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                return n * Ankieta(n-1);
            }
        }*/

        /*zad1
        public static int kp1z1(int a, int b)
        {
            return a * a + b * b;
        }

        public static bool kp2z2 (int a)
        {
              f (a >= 100 && a <= 999 && a % 17 == 0)
                 return true;
              else
                 return false;*//*

            return a >= 100 && a < 1000 && a % 17 == 0 ? true : false;
        }
        
        public static bool kp2z6 (int a, int p)
        {
            return ((Math.Pow(a, p) - a) % p == 0) ? true : false;      
        }

        public static void kp3z1 (int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i * i * i + 3 + "");
            }
        }

        public static ArrayList kp3z3 (int x)
        {
            ArrayList alist = new ArrayList();
            for (int i = 0; i < x+1; i++)
            {
                if (x % 1 == 0)
                {
                    alist.Add(i);
                }
            }
            return alist;
        }
        */
        static void Main(string[] args)
        {
            /* zad1
                         kp1z1
                         int a = int.Parse(Console.ReadLine());
                         int b = int.Parse(Console.ReadLine());
                         Console.WriteLine(kp1z1(a, b));


                         kp2z2
                         int a = int.Parse(Console.ReadLine());
                         Console.WriteLine(kp2z2(a));


                         kp2z6
                         int a = int.Parse(Console.ReadLine());
                         int p = int.Parse(Console.ReadLine());
                         Console.WriteLine(kp2z6(a, p)); 

                         kp3z1
                         int n = int.Parse(Console.ReadLine());
                         kp3z1(n);


                         ArrayList dzielniki = new ArrayList();
                         int n = int.Parse(Console.ReadLine());
                         dzielniki = kp3z3(n);
                         foreach(int a in dzielniki)
                         {
                             Console.WriteLine(a + " ");
                         }
             */

            /*            Zad 3
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine(Silnia(n));*/
            /*
                        samodzielny porzyklad
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine(Ankieta(n));
                                    Console.ReadKey();
            */

            /*Zad4*//*
                int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(n));*/

        }
    }

    public class ArrayList
    {
    }
}
