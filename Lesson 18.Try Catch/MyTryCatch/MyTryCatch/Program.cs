// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
//throw - це спеціальне слово, яке використовується для генерації помилки
//Дана помилка буде оброблятися через catch
//
Console.WriteLine("Скільки Вам років:");
string str = Console.ReadLine();
try //Коди у якому може бути вилют програми
{
    uint age = uint.Parse(str); //int 32 - біта в числі - 4 байти - 2^32
    if (age < 18)
        throw new Exception("Дуже малельник вік. Ви не може це бачити");
    Console.WriteLine("Вітаємо Вам " + age + " років");
}
catch(FormatException fex) //Якщо вказує не вірний формат
{
    Console.WriteLine("Ви не вірно вказали цифри для віку");
}
catch(OverflowException ofex)
{
    Console.WriteLine("Вік вийшов за межі допустимі int32");
}
//Exception - зберігає помилки - зберігає усі помилкі,
//які тільки можуть бути
catch(Exception kovbaska) //Блок коду, коли виникає помилка
{
    string message = kovbaska.Message; //Текст помилки, який дає програма
    //Console.WriteLine(kovbaska);
    Console.WriteLine("Хюсто у нас проблеми :(" + message);
}
finally
{
    //Це блок завжди спрацьовує.
    //Не важко як працювали
    Console.WriteLine("Дякую, що у Вас працював код. Допобачення");
}





