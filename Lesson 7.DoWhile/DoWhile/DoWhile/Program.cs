// See https://aka.ms/new-console-template for more information
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Привіт Козаки і Козачки");


int action = 0; // 0 - вихід
//Цикл з передумовою
do  //спочатку виконується тіло циклу
{
    Console.WriteLine("0.Вихід");
    Console.WriteLine("1.Привітання");
    Console.WriteLine("2.Насилання листівки");
    while (true)
    {
        try //блок коду, в якому може статися помилка
        {
            Console.Write("->_");
            string text = Console.ReadLine();
            //action = int.Parse(Console.ReadLine());
            action = Convert.ToInt32(text);
            break; //якщо все добре, виходимо з циклу while
        }
        catch //якщо сталася помилка, виконується цей блок
        {
            Console.WriteLine("Не вірно вказно дані :)");
            action = -1; //щоб не вийти з програми
        } //якщо сталася посилка
    }
    switch(action)
    {
        case 1: 
            Console.WriteLine("Привіт Козаки і Козачки");
            break;

        case 2:
            Console.WriteLine("Надіслана листівка із букетом. :)");
            break;

        default: //Якщо вводимо не 1 і не 0
            if (action!=0)
                Console.WriteLine("Не вірна дія");
            break;
    }


} while (action!=0); //потім перевіряється умова