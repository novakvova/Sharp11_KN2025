// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Створюємо масив цілих чисел(int), який називається list
// {} - ініціалізація масиву при стоворені -
//int[] list = { 5,8,23,12 };
//Номерація індексів масиву починається з - 0
//int n = list.Length; //n - зберігає кількість елементів масиву
/*
for (int i = 0; i < n; i=i+1)
{
    Console.Write($"{list[i]}\t");
} */
//int item - змінна циклу, яка набуває значення кожного разу при роботі
//циклу - туди записуються значення list[0] на 1 ітерації
//На наступній ітерації буде int item = list[1]
//Третя ітераці item = list[2]
//Перебирає автоматично і записує на кожній ітерації у змінну item
//наступний елемент масиву
//foreach (int item in list)
//{
//    Console.Write($"{item}\t");
//}

//Console.WriteLine("Усіх із св'ятом. День захисника вітчизни та Покрови");

string[] names =
{
    "Нестор",
    "Владислав",
    "Вова",
    "Єлизавета",
    "Кароліна"
};

Console.WriteLine("---Наша команда---");
foreach (var bimbo in names)
{
    Console.WriteLine(bimbo);
}