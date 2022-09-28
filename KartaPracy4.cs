using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*         zad 1
             *         int a, b;
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine((a*a)+(b*b));
                        Console.ReadKey(); */

            /*            int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(a*a + b*b); */

            /*           zad 2
             *           int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        int z = int.Parse(Console.ReadLine());

                        if (x >= y && y >= z) Console.WriteLine($"{x} {y} {z}");
                        else if (x >= z && z >= y) Console.WriteLine($"{x} {x} {y}");
                        else if (y >= x && x >= z) Console.WriteLine($"{y} {x} {z}");
                        else if (y >= z && z >= x) Console.WriteLine($"{y} {z} {x}");
                        else if (z >= x && x >= y) Console.WriteLine($"{z} {x} {y}");
                        else if (z >= y && y >= z) Console.WriteLine($"{z} {y} {x}");

                        Console.ReadKey();*/

            /*         zad 4
             *         int a = int.Parse(Console.ReadLine());
                        int wynik = 1;
                        for (int i = 1; i <= a; i++)
                        {
                            wynik = wynik * i;
                        }
                        Console.WriteLine(wynik);*/

            /*           zad 5
             *           for (int i = -7; i <= 17; i+=4)
                        {
                            Console.WriteLine(i);
                        }*/
            /*          
             *          zad  5while
                        int a = -7;
                        while (a <= 17)
                        {
                            Console.WriteLine(a);
                            a = a + 4; 
                        } */
            /*
             *          zad 9
                        int suma = 0;
                        int liczba = int.Parse(Console.ReadLine());
                        while(liczba > 0)
                        {
                            liczba /= 10;
                            suma += 1;
                        }
                        Console.WriteLine(suma);*/

/*       zad 8
 *       int n = int.Parse(Console.ReadLine());
            bool flaga = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flaga = false;
                    break;
                }
            }
            if (flaga) Console.WriteLine("Jest pierwsza ");
            else Console.WriteLine("Nie jest pierwsza");*/
        }
    }
}
