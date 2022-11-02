/* zad 1
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 100; i < n+100; i++)
{
    suma += i;
}
Console.WriteLine($"{suma}");*/

/*
zad 2
int k = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int suma = 0;
int temp;
for (int i = 0; i < k; i++)
{
    temp = a;
    a = b;
    b = temp + b;
    suma = suma + b;
}
Console.WriteLine(suma);*/

/* zad 3
int x = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i < x; i++)
{
    if (x % i == 0)
    {
        suma = suma + i;
    }
}
if (x == suma)
{
    Console.WriteLine("Jest doskonała");
}
else { 
    Console.WriteLine("Nie jest doskonała");
}*/

int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += ((int)(3 * Math.Pow(2, i)));
}
Console.WriteLine(suma);
