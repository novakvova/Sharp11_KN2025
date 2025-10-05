using System.Text;

//правила написання коду ті самі, що змінних типів
namespace Beaver //Простір імен - для даних типів
{
    class Salo // слова Program - може бути будь-яке
    {
        static void Main() //точка входу в програму - Без цієї функції код не працює
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //Данна змінна використовується для генерації випадкових чисел
            Random vova = new Random(); //створення об'єкта класу Рандом

            int i = 0, a = 20; //оголошення змінної
            /*
            for(; i<a; i=i+1)
            {
                //Геренуємо число від 1 до 9
                int number = vova.Next(1, 10);
                Console.WriteLine("Number = " + number);
                if(number == 3)
                {
                    Console.WriteLine("---Нам не пощастило---");
                    break; //завершує цикл
                }
            }
            */
            
            while(i<a)
            {
                Console.WriteLine("i = " + i);

                i = i + 1;
            }

            //Console.WriteLine("Привіт козаки!");
        }
    }
}


