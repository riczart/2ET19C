using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*            zad 1
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(i * i * i + 3);
                        }*/

            /*            zad 2
                        for (int i = 105; i < 1000; i+=15)
                        {
                            Console.WriteLine(i);
                        }*/
            /*
                        zad 3
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            if (n % i == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }*/

            /*            zad 4
                        int suma = 0;
                        for (int i = 10; i < 100; i++)
                        {
                            suma = suma + i;
                        }
                        Console.WriteLine(suma);
            */

            /*            zad 5
                        Console.WriteLine("Podaj liczbe w ktora gramy (n) ");
                        int n = int.Parse(Console.ReadLine());
                        int suma =n * (n + 1) / 2;
                        int liczba;
                        Console.WriteLine($"OK, to podaj {n-1} liczb, a ja zgadne ta ktorej nie podales");
                        for (int i = 0; i < n - 1; i++)
                        {
                            liczba = int.Parse(Console.ReadLine());
                            suma = suma - liczba;
                        }
                        Console.WriteLine($"Wybrales sobie {suma}");*/
/*
            zad 6
            Console.WriteLine("Ile chcesz tych liczb Fibonacciego");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;
            for (int i = 0; i < n-2; i++)
            {
                temp = b;
                b = a + b;
                a = temp;
            }
            Console.WriteLine();*/
        }
    }
}
