// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//n - кількість рядків
//m - кількість стовпців
int n, m;
Console.Write("Вкажіть n = ");
n = int.Parse(Console.ReadLine()!);
Console.Write("Вкажіть m = ");
m = int.Parse(Console.ReadLine()!);

//оголошення масиву
int[,] a = new int[n,m]; //масив розміром n*m

Random rand = new Random();

//заповнення масиву випадковими числами
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i,j] = rand.Next(1, 20); //випадкові числа від 1 до 19
    }
}

//виведення масиву на екран
Console.WriteLine("Матриця A:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i,j].ToString() + "\t");
    }
    Console.WriteLine();
}


//оголошення масиву
int[,] b = new int[n, m]; //масив розміром n*m

//заповнення масиву випадковими числами
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        b[i, j] = rand.Next(1, 20); //випадкові числа від 1 до 19
    }
}

Console.WriteLine("Матриця B:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(b[i, j].ToString() + "\t");
    }
    Console.WriteLine();
}


//оголошення масиву для добутку
int[,] c = new int[n, m]; //масив розміром n*m
//обчислення добутку матриць
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int sum = 0;
        for (int k = 0; k<n; k++)
        {
            sum += a[i, k] * b[k, j]; //Шукаємо суму добутків елементів рядка i матриці a на елементи стовпця j матриці b
        }
        c[i, j] = sum;
    }
}
Console.WriteLine("Матриця С:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(c[i, j].ToString() + "\t");
    }
    Console.WriteLine();
}

