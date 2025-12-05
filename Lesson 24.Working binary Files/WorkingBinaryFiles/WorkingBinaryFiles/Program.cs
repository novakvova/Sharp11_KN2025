// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Console.WriteLine("Вкажіть шлях до файлу:");
//string filePath = Console.ReadLine();

//if(string.IsNullOrEmpty(filePath))
//{
//    Console.WriteLine("Ви вказали пустий рядок");
//    return;
//}

//if(!File.Exists(filePath)) // ! означає "не" - якщо файл не існує
//{
//    Console.WriteLine("Файл не знайдено.");
//    return;
//}
//"C:\Users\hp\Desktop\images\Cat please.png"
//Шлях до файлу в мережі
//https://www.alleycat.org/wp-content/uploads/2019/03/FELV-cat.jpg
string urlFile;
Console.WriteLine("Вкажіть адресу файлу:");
urlFile = Console.ReadLine();
try
{
    //Цей клас вміє отримувати файли з інтернету
    HttpClient httpClient = new HttpClient();
    //string file = "https://www.cdc.gov/healthy-pets/media/images/2024/04/Cat-on-couch.jpg";
    byte[] imageBytes = await httpClient.GetByteArrayAsync(urlFile);
    File.WriteAllBytes("myFile.jpg", imageBytes);
} 
catch (Exception ex)
{
    Console.WriteLine("Сталася помилка при завантаженні файлу: " + ex.Message);
}

//Читаю байти із файлу
//byte[] fileBytes = File.ReadAllBytes(filePath);
//Console.WriteLine("Вказіть назву нового файлу або шлях");
//string newFilePath = Console.ReadLine();
//Записую байти у новий файл
//File.WriteAllBytes(newFilePath, fileBytes);
//Текстовий файл має розширення .txt
//Файли з фото мають розширення .jpg, .png, .gif - це бінарні файли
// jpg - формат у якому закодваний бінарний файл
//Файли з відео мають розширення .mp4, .avi, .mov - це бінарні файли



