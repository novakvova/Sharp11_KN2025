// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Який у Вас вік?");
//створив змінну text, яка зберігає у собі текст, який вводить користувач
string text = Console.ReadLine();
//age - зберігає у собі цілі числа додатні і від'ємні
int age = int.Parse(text);

if(age < 18)  //якщо вік менший за 18
{ //тіло if - виконується, якщо умова істинна
    Console.WriteLine("Вітаємо ви є неповнолітній");
}
else if(age < 25) //якщо 1 умова age < 18 тоді ми перевіряємо далі
{
    Console.WriteLine("Ваш вік - ще не призовник");
}

else if(age < 60)
{
    Console.WriteLine("Ви - дорослий і крутий");
}
else if(age < 150)
{
       Console.WriteLine("Ви - пенсіонер");
}
else //інакше
{
    Console.WriteLine("Ви вказали не допустимий вік");
}
    



