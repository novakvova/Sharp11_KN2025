// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Робота з файлами та масивами.");

string[] cities = ["Київ", "Львів", "Рівне", 
    "Харків", "Сімферопіль", "Херсон"];
//Зберігає міста
string fileName = "cities.txt"; 

//Записав усі міста у файл - 
//fileName - назва файлу
//cities - наші місті
File.WriteAllLines(fileName, cities);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---Міста записно у файл успішно---");

string[] fileCities = File.ReadAllLines("cities.txt");
Console.ForegroundColor= ConsoleColor.Yellow;
Console.WriteLine("Міста, які у файлі");
foreach (var city in cities)
{
    Console.WriteLine(city);
}

