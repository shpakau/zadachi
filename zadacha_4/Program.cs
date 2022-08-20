// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = 2;
int b = 3;
int c = 7;
int d = 44;
int e = 5;
int f = 78;
int g = 22;
int h = 3;
int i = 9;
int max = a;
int max1 = d;
int max2 = g;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max1) max1 = d;
if (e > max1) max1 = e;
if (f > max1) max1 = f;
if (g > max2) max2 = g;
if (h > max2) max2 = h;
if (i > max2) max2 = i;
Console.WriteLine("Ответы:");
Console.Write("по первому условию Max = ");
Console.WriteLine(max);
Console.Write("по второму условию Max = ");
Console.WriteLine(max1);
Console.Write("по третьему условию Max = ");
Console.WriteLine(max2);