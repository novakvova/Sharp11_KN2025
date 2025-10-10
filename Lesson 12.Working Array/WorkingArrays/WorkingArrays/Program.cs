// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

int[] list = new int[6]
{
    34, 12, 18, 3, 9, 21
};

foreach (int i in list)
{
    string str = String.Format("{0}\t", i);
    //Console.Write("{0}\t", i);
    Console.Write(str);
}
Console.WriteLine();

//Console.WriteLine("List:");
int n = list.Length;

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("lіst[{0}] = {1}", i, list[i]);
//}
int numberIf = 0; //Рахуємо кількість перевірок if
//Перебирає усі елементи до n-1 - 3
for (int i = 0; i < n-1; i++)
{
    //Перебирає усі елементи
    for (int j = 0; j < (n - i - 1); j++)
    {
        numberIf++; //numberIf = numberIf+1;
        if(list[j] > list[j+1])
        {
            //list[j] = list[j+1];   //34 = 12
            //list[j+1] = list[j];   //12 = 12
            
            int temp = list[j];  //12
            list[j] = list[j+1]; //12 = 34
            list[j+1] = temp;    //34 = 12
        }
    }
}
Console.WriteLine("Сортований масив");
foreach (int i in list)
    Console.Write($"{i}\t");
Console.WriteLine();

Console.WriteLine($"Ефективність роботи методу бульбашки {numberIf}");
// 34, 12, 18, 3
// i = 0; 
// j = 0; j<(n-i-1), j<3 
//--------j==0----------------
//if(34>12) 
//12,34,18,3
//-------j==1----------------
//if(34>18)
//12,18,34,3
//-------j==2-----------
//if(34>3)
//12,18,3,34

//----------------------
//----------------------
// i = 1
// j = 0; j<(n-i-1), j<2
// ----------j==0-----------
//if(12>18
//12,18,3,34
//-----------j==1---------------
//if(18>3)
//12,3,18,34

//i=2
//j=0; j<(n-i-1); j<1
//-----------j==0-------------
//if(12>3
//3,12,18,34

//--------i=3 Умова не виконується масив відсортовано---------


