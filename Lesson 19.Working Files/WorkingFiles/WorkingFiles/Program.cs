// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Console.WriteLine("Привіт команда");

//Файл - це найменоване місце не диску для зберігання інформації
//Дозволяє працювати із файлми
//File - Для роботи з файлами
//WriteAllText() - Це функція, яка приймає на себе назву файлу або
//шлях і примає текст, який потрібно записати у файл.
// -----------Запис даних у файл------------
//string fileName = "myText.txt"; //Назва файлу, куди будемо писати інформацію
//string text = "Пишому код і насолоджуємося цим процесом";
//File.WriteAllText(fileName, text); //Виводимо у файл myText.txt - наш текст

//-------------Читання даних із файлу.-------------------
//string fileName = "myText.txt";
//string text = File.ReadAllText(fileName); //повертає дані, які є у файлі
//Console.WriteLine("----------Вміст файлу--------");
//Console.WriteLine(text);


int action = 0;

do
{
    Console.WriteLine("1.Читання даних з файлу");
    Console.WriteLine("2.Запис тексту у файл");
    Console.Write("->_");
    string text = Console.ReadLine();
    int.TryParse(text, out action);
    switch(action)
    {
        case 1:
            {
                Console.WriteLine("Вкажіть шлях або назву файлу:");
                string fileName = Console.ReadLine();
                string fileText = File.ReadAllText(fileName);
                Console.WriteLine("---------Вміст файлу----------");
                Console.WriteLine(fileText);
                break;
            }

        case 2:
            {
                Console.WriteLine("Вкажіть шлях або назву файлу:");
                string fileName = Console.ReadLine();
                Console.WriteLine("Вкажіть вміст файлу");
                string fileContent = Console.ReadLine();
                File.WriteAllText(fileName, fileContent);
                break;
            }
    }

} while (action!=0);
    
