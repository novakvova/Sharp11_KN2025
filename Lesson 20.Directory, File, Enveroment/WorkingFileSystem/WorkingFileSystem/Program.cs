// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


//Призначений для отримання інформації про ОС і диски на вашого ПК
//Environment.CurrentDirectory
//---------------------------Enveroment---------------------------------
/*
Console.WriteLine($"Ваша поточн папка {Environment.CurrentDirectory}");
Console.WriteLine($"Інформація про ПК ядра {Environment.ProcessorCount}");
Console.WriteLine($"Версія OS ядра {Environment.OSVersion}");

string[] drives = Environment.GetLogicalDrives();
Console.Write($"Диски на вашого ПК ");
foreach (string drive in drives)
    Console.Write($"{drive}, ");
Console.WriteLine();
*/

//Клас для роботи з папками або каталогами
//Список папок у поточній папці
//path - шлях до папки 
string path = "C:\\";
var list = Directory.GetDirectories(path);
Console.WriteLine($"Список папок по шляху {path}");
foreach(var item in list)
{
    Console.WriteLine(item);
}
//Отримує інформацію про файли у папці
var files = Directory.GetFiles(path);
Console.WriteLine($"Файли у папці {files}");
foreach (var file in files)
{ 
    Console.WriteLine(file); 
}

Console.WriteLine("Вкажіть назву папки:");
string folderName = Console.ReadLine();

string pathFolder = path + folderName; //Обєднуємо шлях із папкою
if(Directory.Exists(pathFolder))
{
    Console.WriteLine("Дана папка існує :)");
}
else
{
    Console.WriteLine("Створити папку? так/ні");
    string yes = Console.ReadLine();
    if(yes != null) //не пустий рядок
    {
        if(yes.ToLower() == "так")
        {
            Directory.CreateDirectory(pathFolder);
        }
    }
}



