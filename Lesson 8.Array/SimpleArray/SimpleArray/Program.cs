// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("Привіт! Класна погода :)");
//Створив масив цілих чисел, який містить вік собак
//Масив називається dogs
//Масив створеного і його ініаціалзоваоно у одному рядку
//іціціалізація - надання значень елементам масиву
/* ---------- Example 1 ------
int[] dogs = { 12, 8, 8, 2 };

//ім'я масиву dogs потім [] - індекс елемента масиву
dogs[1] = 16; //зміна значення елемента масиву з індексом 1

int n = 4; //розмір масиву - кількість ітерацій циклу
for (int i = 0; i < n; i=i+1) // i=i+1 - збільшення лічильника на 1 
{
    Console.WriteLine(dogs[i]);
}
*/
//Console.WriteLine(dogs[0]);
//Console.WriteLine(dogs[1]);
//Console.WriteLine(dogs[2]);
//Console.WriteLine(dogs[3]);



//int dog1 = 12;
//int dog2 = 8;
//int dog3 = 8;



int n = 5;
string[] cats = new string[n];

Console.WriteLine("Вкажіть назви Вашх котиків:");
for (int i = 0; i < n; i=i+1)
{
    Console.Write($"Котик № {i + 1}: ");
    cats[i] = Console.ReadLine();
}

Console.WriteLine("Назви Ваших котиків:");
for (int i = 0; i < n; i=i+1)
{
    Console.Write(cats[i]+"\t"); // \t - табуляція
}
Console.WriteLine();