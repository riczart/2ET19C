/*zadanie 1
Console.WriteLine("Dni listopada:");
for (int i = 1; i <= 30; i++)
{
    Console.Write($"{i}, ");
}*/

/*zadanie 2
Console.WriteLine("Prosze podac zakres liczb");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i += 2)
{
    Console.Write($"{i*i}, ");
}*/

/*zadanie 3
for (int i = 1000; i < 10000; i++)
{
    if(i % 379 == 0) 
    {
        Console.Write($"{i}, ");
    }
}*/

/*zadanie 4
for (int i = 100; i < 1000; i++)
{
    if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
    {
        Console.Write($"{i}, ");
    }
}*/

/*zadanie 5
Console.WriteLine("Prosze podac ile liczb");
int nliczb = int.Parse(Console.ReadLine());
int a = 0;
int suma = 0;
for (int i = 0; i < nliczb; i++)
{
    Console.WriteLine($"Prosze podac {i+1} liczbe: ");
    a = int.Parse(Console.ReadLine());
    suma += a;
}
Console.WriteLine($"{suma}");*/

/*zadanie 6
Console.WriteLine("Prosze podac ilosc poczatkowych liczb parzystych");
int k = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i <= k; i+=2)
{
    suma += i;
}
Console.WriteLine($"Suma liczb wynosi = {suma}");*/

/*zad 7
Console.WriteLine("Prosze podac ilosc poczatkowych liczb nieparzystych dwucyfrowych");
int m = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 11; i < (m * 2) + 10; i += 2)
{
    suma += i;
}
Console.WriteLine($"Suma liczb wynosi = {suma}");*/


/*zadanie 8
Console.WriteLine("Prosze podac kwote");
int w = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj okres inwestycji w latach");
double kwota = double.Parse(Console.ReadLine());
double wynik = 0;
double miesiace = w * 12;
for (int i = 0; i < w; i++)
{
    wynik += kwota * 6.00 / 100;
}
kwota += wynik;
Console.WriteLine($"{kwota}");*/

/*zadanie 9 
Console.WriteLine("Prosze podac liczbe");
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 21; i <= (n-1)*100+21; i+=100)
{
    suma += i;
}
Console.WriteLine($"Suma wynosi {suma}");*/


/*zadanie 10
for (int i = 0; i < 32; i++)
{
    int a = i * i;
    if (i < 10)
        while (a >= 10)
            a -= 10;
    else
        while (a >= 100)
            a -= 100;
    if (a == i)
        Console.WriteLine(i * i);
}*/
