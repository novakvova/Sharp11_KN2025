// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


int[] simple = { 4, 6, 12, 8 };
//Console.WriteLine(simple);
foreach (int item in simple)
{
    Console.Write($"{item}\t");
}
Console.WriteLine();

int[,] a =
{
    { 3,  7,  12 },
    { 4,  6,  18 },
    { 45, -6, 87 }
};
int n = 3, m = 3;
Console.WriteLine("----Matrix A----");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{a[i,j]}\t");

    Console.WriteLine();
}

//Користувач вводить розмір масиву n і m
//Програма має створити масив на етапі виконання коду
//Після цього програма заповняє масив
//Рандомними числами (18, 60) і виводить його користувачу.


//Console.WriteLine("Привіт масиви :)");
