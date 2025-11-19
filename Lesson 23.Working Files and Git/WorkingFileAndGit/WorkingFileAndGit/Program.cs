// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Вкажіть шлях до папки:");
//якщо користувач вказав пустий рядок, то використовується шлях "c:\"
string folderPath = Console.ReadLine() ?? "c:\\";

if (Directory.Exists(folderPath) == false) //якщо шлях вказано не вірно, то виходимо з програми
{
    Console.WriteLine("Вказана папка не існує.");
    return;
}
/*
string[] dirs = Directory.GetDirectories(folderPath);
Console.WriteLine("--Список папок у даній папці--:");
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}
*/

string[] files = Directory.GetFiles(folderPath);
/*
Console.WriteLine("--Список файлів у даній папці--:");
foreach (string file in files)
{
    Console.WriteLine(file);
}
*/
//Кількість роширель файлів максимальна можу бути згідно кількості файлів у папці
//Якщо усі файли будуть різні, то розширень буде стільки ж скільки і файлів
string[] fileExxts = new string[files.Length];
//Починаю шукати кільсть унікальних розширень файлів
int n = files.Length;
int uniqueExtCount = 0; //рахунокчик унікальних розширень
for (int i=0; i<n; i++)
{
    string fileName = files[i];
    //Згідно імені отримую розширення файлу
    string fileExt = Path.GetExtension(fileName); //Дозволяє отримати розширення файлу
    bool isFound = false; //Чи є дане роширення у списку рошишень
    for (int j=0; j<uniqueExtCount; j++)
    {
        if (fileExxts[j] == fileExt)
        {
            isFound = true; //Дане роширення вже є у списку
            break;
        }
    } 
    if (isFound == false)
    {
        //Додаю нове унікальне розширення до списку
        fileExxts[uniqueExtCount] = fileExt; //
        uniqueExtCount++; //Збільшую кількість унікальних розширень
    }
    //Console.WriteLine(fileExt);
}

Console.WriteLine("Список унікальних роширень файлів:");
for (int i = 0; i < uniqueExtCount; i++)
{
    var ext = fileExxts[i]; //Отримую розширення
    //Рахую кількість файлів з даним розширень
    int count = 0;
    for (int j = 0; j < n; j++)
    {
        string fileName = files[j];
        string fileExt = Path.GetExtension(fileName);
        if (fileExt == ext)
        {
            count++;
        }
    }
    Console.WriteLine(fileExxts[i] + "\t" + count);
}


