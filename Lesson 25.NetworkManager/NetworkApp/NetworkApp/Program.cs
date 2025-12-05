// See https://aka.ms/new-console-template for more information
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Класна погода і гарний настрій :)");
string[] listUrls = new string[1000]; //максимальна кількіст файлів 1000
int count = 0; 
do
{
    Console.WriteLine("Вкажіть шлях до файлу у мережі (або натисніть Enter для виходу):");
    string temp = Console.ReadLine();
    if (temp == String.Empty)
    {
        break;
    }
    listUrls[count++] = temp;
} while (true); 

int counterSuccess = 0;
string girls = "girls";
for (int i = 0; i<count; i++)
{
    try
    {
        HttpClient httpClient = new HttpClient();
        byte[] imageBytes = httpClient.GetByteArrayAsync(listUrls[i]).Result;
        string fileName = Guid.NewGuid().ToString() + ".jpg";
        string path = Path.Combine(girls, fileName);
        Directory.CreateDirectory(girls);
        File.WriteAllBytes(path, imageBytes);
        counterSuccess++;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Хюстон у нас проблеми {listUrls[i]}: {ex.Message}");
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Загальна кількість файлів: {count}, " +
    $"успішно завантажено: {counterSuccess}");


/*
Console.WriteLine("Вкажіть шлях до файлу у мережі:");
string urlFile = String.Empty;
urlFile = Console.ReadLine() ?? String.Empty;
if (urlFile == String.Empty)
{
    Console.WriteLine("Шлях до файлу не вказано!");
    return;
}
try
{
    HttpClient httpClient = new HttpClient();
    byte[] imageBytes = httpClient.GetByteArrayAsync(urlFile).Result;


}
catch (Exception ex)
{
    Console.WriteLine($"Трапилася халепа: {ex.Message}");
}
*/