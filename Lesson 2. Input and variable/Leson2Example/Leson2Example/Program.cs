Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("Привіт! Класна погода");
/*
string name = "Йосип"; //sizeof

Console.WriteLine(name);

Console.WriteLine("Вкажіть Ваше ім'я: ");
name = Console.ReadLine();

Console.WriteLine("Вас завати: " + name);
//один символ - це тип даних char
Console.WriteLine("Розмір 1 символу " + sizeof(char));
*/
int a; //Зберігає ціе число - a
int b; //Зберігає ціе число - b
Console.Write("Вкажіть a ->_");
string str = Console.ReadLine(); //Зчитує текст з консолі
a =  int.Parse(str); //Перетворює текст в число
Console.Write("Вкажіть b ->_");
str = Console.ReadLine(); //Зчитує текст з консолі
b =  int.Parse(str); //Перетворює текст в число
int c = a + b; //Зберігає суму a та b
Console.WriteLine("a + b = " + c);


