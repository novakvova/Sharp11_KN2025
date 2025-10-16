// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт Козаки і Козачки :)");

//Cтворюємо масив 2х2
//Я маю масив, який склається з 2 рядків,
//[] - не зрозуміло скільки стовпчиків
int[][] a = new int[2][];
a[0] = new int[2]; //У пешому рядку - 2 стовпчика
a[1] = new int[2]; //У другому ряку - 2 стовпчика

//Індексаці масиву починається з 0
a[0][0] = 2;
a[0][1] = 4;
a[1][0] = 8;
a[1][1] = 6;

Console.Write($"{a[0][0]}\t");
Console.Write($"{a[0][1]}\n");
Console.Write($"{a[1][0]}\t");
Console.Write($"{a[1][1]}\n");

Console.WriteLine("\n\n--Вивід масиву через цикл--");
int n = 2; //кілкість рядків
int m = 2; //кількість стовпчиків
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        Console.Write($"{a[i][j]}\t");
    }
    Console.WriteLine();
}    