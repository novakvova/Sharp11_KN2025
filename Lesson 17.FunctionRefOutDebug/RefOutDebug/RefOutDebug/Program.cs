// See https://aka.ms/new-console-template for more information
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("Привіт козаки!");

// ref and out
// ref - посилання (вказівник) на змінну, тобто по даній
//змінній у серединій фукнції її можна змінювати

//ref int a - назва змінної, яка передаєть у фукцію за посиланням
void myTestFunction(ref int a) //myTestFunction - не назва фукнції
{
    a = a + 10;
    Console.WriteLine($"У myTestFunction з ref a = {a}");
}

void myNoRef(int a)
{
    a = a + 10;
    Console.WriteLine($"У myNoRef з a = {a}");
}
/*
int age = 25;
myTestFunction(ref age);
//myNoRef(age);
Console.WriteLine($"Після myTestFunction з ref age = {age}");
*/


// out - вказує на те, що змінна яка передається у фукнцію
// має бути змінена, тобто отримати у ході робити фукнції якесь значення

void myTestOut(out int a)
{
    a = 16;
}

//int pig;
//myTestOut(out pig);
//Console.WriteLine($"Після myTestOut out pig = {pig}");
//Зробити власну фукнцію, який перетворює тест у число.
//Наприклад 
//"25" -> 25
//"abc" -> 0
//Фукнція має приймати рядок і out int - змінна куди записати результат
//string text = "45";
//int number;
//ConvertStringToInt(text, out number);
/*
int age;
Console.WriteLine("Вкажіть Ваш вік:");
string? input = Console.ReadLine(); //input може бути null - пустий рядок
int.TryParse(input, out age); //Спроба перетворити input у age
Console.WriteLine("Вітаємо Вам " + age);
*/
int b;
ConvertStringToInt("abc", out b);
ConvertStringToInt("23", out b);

void ConvertStringToInt(string text, out int result)
{
    result = -1; //по змовчувані змінні дорівнються 0
    if(int.TryParse(text, out result))
    {
        Console.WriteLine($"{text} -> {result}");
    }
    else
    {
        Console.WriteLine($"{text} -> 0");
    }
}