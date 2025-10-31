// See https://aka.ms/new-console-template for more information
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
///Фукнція - це блоку коду, який виконує певну роботу
///Фукнція має назву і ми по цій назві можемо її використовувати
///Оголошення функції починається із ключового слова void, якщо функція нічого не повертає
///void PrintHello() - оголошення функції з назвою PrintHello
void PrintHello()//у тужках ми можемо передавати параметри функції
{ //Тіло функції - це блок коду, який виконується при виклику функції
    Console.WriteLine("Добрий ранок козаки і козачки!");
} //Кінець оголошення функції
void PrintHelloCount()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Добрий ранок козаки і козачки!");
    }
}
///Функція з параметром
///Параметр - це змінна, яка приймає значення при виклику функції
///Змінна яка прилітає у функцію називається формальним параметром
void PrintHelloCountParam(int count) //формальний параметр count
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Добрий ранок козаки і козачки!");
    }
}
//Виклик функції - це використання функції по її назві
//PrintHello(); // Виклик функції PrintHello
//PrintHelloCount(); // Виклик функції PrintHelloCount
//PrintHelloCountParam(15); // Виклик функції PrintHelloCountParam з аргументом 2 - фактичним параметром

//Функція примає параметри по замовчуванню
void GenerateRandomArray(int count, int min=10, int max=21)
{
     //= 5;
    int[] duplo = new int[count];

    Random rand = new Random();
    for (int i = 0; i < count; i++)
    {
        duplo[i] = rand.Next(min, max);
    }
    for (int i = 0; i < count; i++)
    {
        Console.Write(duplo[i] + " ");
    }
}

//GenerateRandomArray(7);
GenerateRandomArray(7,16,48);
