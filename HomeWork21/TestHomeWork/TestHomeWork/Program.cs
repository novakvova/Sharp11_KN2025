using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Вкажіть шлях до папки:");
string folderPath = Console.ReadLine();

if (!Directory.Exists(folderPath))
{
    Console.WriteLine("Папка не знайдена!");
    return;
}

// Отримуємо всі підпапки
string[] directories = Directory.GetDirectories(folderPath);

// Отримуємо всі файли
string[] files = Directory.GetFiles(folderPath);

Console.WriteLine($"----У папці знаходиться----:");
Console.WriteLine($"\tПапок: {directories.Length}");
Console.WriteLine($"\tФайлів: {files.Length}");

Console.WriteLine("\n----Групування файлів за розширенням----:");

string[] fileExt = new string[100];
int findCount = 0;
foreach (var file in files)
{
    string ext = Path.GetExtension(file).ToLower();
    bool isFound = false;
    for(int i=0;i<findCount;i++)
    {
        if (ext == fileExt[i])
        {
            isFound = true;
            break;
        }
    }
    if(!isFound)
    {
        fileExt[findCount]=ext;
        findCount++;
    }
}

for(int i=0;i<findCount;i++)
{
    int count = 0;
    foreach(var file in files)
    {
        if (Path.GetExtension(file).ToLower() == fileExt[i])
        {
            count++;
        }
    }
    Console.WriteLine($"{fileExt[i]} — {count} файлів");
}