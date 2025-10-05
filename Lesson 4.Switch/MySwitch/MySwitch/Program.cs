// See https://aka.ms/new-console-template for more information
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Вкажіть номер дня в тижні:");
int day = Convert.ToInt32(Console.ReadLine());

switch(day)
{
    case 1:
        {
            Console.WriteLine("Понеділок");
            break; //Не пускає у настпний case
        }
    case 2:
        {
            Console.WriteLine("Віторок");
            break;
        }
    default:
        {
            Console.WriteLine("Ви вказали не існуючий день");
            break;
        }
}
/*
if(day >= 1 && day <= 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Робочий день");
    Console.ForegroundColor = ConsoleColor.White;
}
else if(day >=6 && day <= 7)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Вихідний :)");
    Console.ForegroundColor = ConsoleColor.White;
}
else 
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Такого дня не снує :(");
    Console.ForegroundColor = ConsoleColor.White;
}
*/
/*
if(day == 1)
{
    Console.WriteLine("Понеділок");
}
else if(day == 2)
{
    Console.WriteLine("Вівторок");
}
else if(day == 3)
{
    Console.WriteLine("Середа");
}
else if(day == 4)
{
    Console.WriteLine("Четвер");
}
else if(day == 5)
{
    Console.WriteLine("П'ятниця");
}
else if(day == 6)
{
    Console.WriteLine("Субота");
}
else if(day == 7)
{
    Console.WriteLine("Неділя");
}
else
{
    Console.WriteLine("Помилка! В тижні лише 7 днів.");
}
*/