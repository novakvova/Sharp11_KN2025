Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//На початку елементів 0
string[] names = new string[0]; //створюємо порожній масив рядків

names = new string[1]; // тепер у масив можна зберігати 1 елемент
names[0] = "Сало";


foreach(string name in names)
{
    Console.WriteLine(name);
}



