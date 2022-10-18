using System;
namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*            Zadanie 1
                        Console.WriteLine("Podaj pierwsza liczba ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj druga liczba");
                        int b = int.Parse(Console.ReadLine());  
                        if ((a+b)%2 == 0)
                        {
                            Console.WriteLine("Liczba parzysta");
                        }
                        else
                        {
                            Console.WriteLine("Liczba nieparzysta");
                        } */

            /*          Zadanie 2
                        Console.WriteLine("Podaj pierwsza liczba ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj druga liczba");
                        int b = int.Parse(Console.ReadLine());
                        double sart = a + b / 2;
                        double sgeo = Math.Pow(a+b,1/2);
                        if (sart > sgeo)
                        {
                            Console.WriteLine("Srednia artemetyczna jest wieksza");
                        }
                        else if (sart < sgeo)
                        {
                            Console.WriteLine("Srednia geometryczna jest wieksza");
                        }*/

            /*            Zadanie 3
                        Console.WriteLine("Prosze podac pierwsza liczbe");
                        int k = int.Parse(Console.ReadLine());
                        Console.WriteLine("Prosze podac druga liczbe");
                        int l = int.Parse(Console.ReadLine());
                        Console.WriteLine("Prosze podac trzecia liczbe");
                        int m = int.Parse(Console.ReadLine());
                        if (k == l && k != m)
                        {
                            Console.WriteLine($"{k} = {l}");
                        }
                        else if (k == m && k != l)
                        {
                            Console.WriteLine($"{k} = {m}");
                        }
                        else if (l == m && k != m)
                        {
                            Console.WriteLine($"{l} = {m}");
                        }
                        else
                        {
                            Console.WriteLine("Zadne nie sa rowne");
                        }*/

            /*            Zadanie 4
                        int[] liczby = new int[4];
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Prosze podac {i+1} liczbe");
                            liczby[i] = int.Parse(Console.ReadLine());
                        }
                        int min = liczby[0];
                        for (int i = 1; i < 4; i++)
                        {
                            if (liczby[i] < min) min = liczby[i];
                        }
                        Console.WriteLine($"Najmniejsza jest {min}");*/

            /*            Zadanie 5
                        Console.WriteLine("Prosze podac pierwszy bok trojkata");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Prosze podac drugi bok trojkata");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Prosze podac trzeci bok trojkata");
                        int c = int.Parse(Console.ReadLine());

                        if (a < b + c && b < a + c && c < a + b)
                        {
                            Console.WriteLine("Liczby spelniaja");
                        }
                        else
                        {
                            Console.WriteLine("Nie spelniaja");
                        }*/

/*            Zadanie 6
            Console.WriteLine("Prosze podac pierwszy bok trojkata");
            float a = int.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podac drugi bok trojkata");
            float b = int.Parse(Console.ReadLine());
            Console.WriteLine("Prosze podac trzeci bok trojkata");
            float c = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Podany liczby moga byc bokami trojkata");
                if (a*a + b*b > c*c)
                {
                    Console.WriteLine("Trojkat ostrokatny");
                }      
                else if ((a * a + b * b == c * c) || (b * b + c * c == a * a) || (c * c + a * a == b * b))
                {
                    Console.WriteLine("Trojkat prostokatny");
                }
                else
                {
                    Console.WriteLine("Trojkat rozwartokatny");
                }
            }
            else
            {
                Console.WriteLine("Nie moga byc bokami trojkata");
            }*/

        }
    }
}
