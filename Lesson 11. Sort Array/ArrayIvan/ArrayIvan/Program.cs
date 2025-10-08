// See https://aka.ms/new-console-template for more information
using System.Text;

//Cортування масиву методом вибору

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Console.WriteLine("Привіт! Класна осінь");
string[] lines = { 
    "Мельник Роман",
    "Марко Тимофій",
    "Ярмо Іван",
    "Дубило Матвій",
    "Козачок Марина",
    "Балкон Андрій"
};

foreach(string word in lines)
{
    Console.WriteLine(word);
}

int[] numbers = { 34, 67, 12,34, -7, 23 };

foreach(int item in numbers)
{
    Console.Write("{0}\t",item);
}
Console.WriteLine();

int n = numbers.Length; //розмір нашого масиву
for(int i = 0; i < n-1; i=i+1)
{
    //Потірбно взяти 1 елемент масиву і порівняти із наступними
    for(int j = i+1; j < n; j=j+1) //цей цикл починається із наступного елементу
    {
        if (numbers[j] < numbers[i]) //якщо наступний мельний за попередній, то міняємо місцями
        {
            //міняю місцями
            int temp = numbers[i]; //запамятав i-тий елемент
            numbers[i] = numbers[j]; //на i-тий записав - j-тий елемент
            numbers[j] = temp; //місце j-того - записую,той щоб був i-тий - TEMP
        }
    }
}

Console.WriteLine("Сортований масиву чисел");
foreach(int item in numbers)
{
    Console.Write("{0}\t", item);
}
Console.WriteLine();


//string one = "А";
//string two = "Ф";

//string one = "Ф";
//string two = "А";

//Console.WriteLine(one.CompareTo(two));

n = lines.Length; //розмір нашого масиву
for (int i = 0; i < n-1; i = i + 1)
{
    //Потірбно взяти 1 елемент масиву і порівняти із наступними
    for (int j = i + 1; j < n; j = j + 1) //цей цикл починається із наступного елементу
    {
        if (lines[i].CompareTo(lines[j])==1) //якщо наступний мельний за попередній, то міняємо місцями
        {
            //міняю місцями
            string temp = lines[i]; //запамятав i-тий елемент
            lines[i] = lines[j]; //на i-тий записав - j-тий елемент
            lines[j] = temp; //місце j-того - записую,той щоб був i-тий - TEMP
        }
    }
}

Console.WriteLine("Сортований масив");
foreach (string word in lines)
{
    Console.WriteLine(word);
}
Console.WriteLine();

