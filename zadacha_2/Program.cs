// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


int a = 5;
int b = 7;
int c = 2;
int d = 10;
int e = -9;
int f = -3;
int max = a;
int max1 = c;
int max2 = e;
int min = a;
int min1 = c;
int min2 = e;
if (a > max) max = a;
if (b > max) max = b;
if (c > max1) max1 = c;
if (d > max1) max1 = d;
if (e > max2) max2 = e;
if (f > max2) max2 = f;
if (a < min) min = a;
if (b < min) min = b;
if (c < min1) min1 = c;
if (d < min1) min1 = d;
if (e < min2) min2 = e;
if (f < min2) min2 = f;
Console.WriteLine("Ответы:");
Console.Write("по первому условию: Max = ");
Console.Write(max);
Console.Write(", а Min = ");
Console.WriteLine(min);
Console.Write("по второму условию: Max = ");
Console.Write(max1);
Console.Write(", а Min = ");
Console.WriteLine(min1);
Console.Write("по третьему условию: Max = ");
Console.Write(max2);
Console.Write(", а Min = ");
Console.WriteLine(min2);

// a = 5; b = 7 -> max = 7
// int a = 5;
// int b = 7;
// int max = a;
// int min = a;
// if (a > max) max = a;
// if (b > max) max = b;
// Console.Write("Max = " );
// Console.WriteLine(max);
// if (a <min) min = a;
// if (b <min) min = b;
// Console.Write("Min = ");
// Console.WriteLine(min);

// a = 2 b = 10 -> max = 10
// int a = 2;
// int b = 10;
// int max = a;
// int min = a;
// if (a > max) max = a;
// if (b > max) max = b;
//  Console.Write("Max = " );
// Console.WriteLine(max);
// if (a <min) min = a;
// if (b <min) min = b;
// Console.Write("Min = ");
// Console.WriteLine(min);

// a = -9 b = -3 -> max = -3
// int a = -9;
// int b = -3;
// int max = a;
// int min = a;
// if (a > max) max = a;
// if (b > max) max = b;
// Console.Write("Max = " );
// Console.WriteLine(max);
// if (a <min) min = a;
// if (b <min) min = b;
// Console.Write("Min = ");
// Console.WriteLine(min);