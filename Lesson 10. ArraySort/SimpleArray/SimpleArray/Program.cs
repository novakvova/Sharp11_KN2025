using Microsoft.VisualBasic.FileIO;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
/*
//На початку елементів 0
string[] names = new string[0]; //створюємо порожній масив рядків

names = new string[1]; // тепер у масив можна зберігати 1 елемент
names[0] = "Сало";

string temp = names[0]; //Зберіг попереднє значення
names = new string[2]; // тепер у масив можна зберігати 2 елемент
names[0] = temp; //ЗБеріг поперднє значення повернув у масив
names[1] = "Борщ";


string temp1 = names[0]; //Зберіг попереднє значення
string temp2 = names[1]; //Зберіг попереднє значення
names = new string[3]; // тепер у масив можна зберігати 3 елемент
names[0] = temp1; //ЗБеріг поперднє значення повернув у масив
names[1] = temp2; //ЗБеріг поперднє значення повернув у масив
names[2] = "Бульйон";


foreach (string name in names)
{
    Console.WriteLine(name);
}

*/
//На початку елементів 0
string[] names = new string[0]; 

Console.WriteLine("Вводьте імена (Enter на порожньому рядку — завершення): "); //інструкція для користувача

while (true) //for(;true;)
{
    string name = Console.ReadLine()!; 
    if (string.IsNullOrWhiteSpace(name))
    {
        break; 
    }
    int n = names.Length; 
    string []temp = new string[n+1]; 
    for (int i = 0; i < n; i++)
    {
        temp[i] = names[i]; 
    }
    temp[n] = name; 
    names = temp; 

}

Console.WriteLine("Імена які ви ввели: "); 

foreach (var n in names) 
{
    Console.WriteLine(n); 
}

Console.WriteLine("Введіть ім'я для пошуку: "); 

string search = Console.ReadLine()!; 

bool found = false; 

foreach (var n in names) 
{
    if (n == search) 
    {
        found = true; 
        break; 
    }
}

if (found) 
{
    Console.WriteLine($"Ім'я {search} знайдено у масиві"); 
}
else
{
    Console.WriteLine($"Ім'я {search} не знайдено"); 
}





//Console.WriteLine("Привіт");

//цикл foreach

//створюємо масив цілих чисел(int), який називається list
// {} - ініціалізатор масиву при створені (вказуємо значення елементів масиву)
//int[] list = {8,7,-7,-8,141};
//нумерація починається з 0
//int n =  list.Length; //властивість Length - довжина масиву (кількість елементів в масиві) //для циклу for

//int item змінна циклу, яка набуває значення кожного разу при роботі
//циклу - туди записуються значенння list[0] на 1 ітерації
//на наступній ітерації item = list[1] 
//третя ітерація item = list[2]
//перебиває автоматично і записує на кожній ітерації у змінну item
//наступний елемент масиву




/*
for (int i = 0; i < n; i++) //цикл for
{
    Console.Write($"{list[i]}\t"); //виводимо елемент масиву з індексом i
}
*/
//Користувач вводить із клавіатури імена
//Довільну кількість - скільки хоче.
//Ввевід завершується, якщо вводить пустий рядок.
//Імена зберігаються у масиві.
//Усі введні користувачем імена ввивести на екран через foreach.
//додати можливість пошуку імені користувача у масиві










