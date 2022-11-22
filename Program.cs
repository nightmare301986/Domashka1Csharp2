//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите 1е число > ");          // Вывод приглашения ввода
string inputValue1 = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int value1 = Convert.ToInt32(inputValue1);    // Преобразование строки в число

Console.Write("Введите 2е число > ");          // Вывод приглашения ввода
string inputValue2 = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int value2 = Convert.ToInt32(inputValue2);    // Преобразование строки в число

Console.Write("Введите 3е число > ");          // Вывод приглашения ввода
string inputValue3 = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int value3 = Convert.ToInt32(inputValue3);    // Преобразование строки в число

int max = value1;

    if (value2 > max) {
       max = value2;
    }
    if (value3 > max) 
    {
       max = value3;
    }

    System.Console.WriteLine("Число " + max + " является максимальным."); 