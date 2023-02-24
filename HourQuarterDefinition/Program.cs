/*
 Используя Visual Studio,создайтепроектпо шаблону Console Application.                                                     
Напишите программу, в которой создайте переменную min. Значение переменной должен задавать 
пользователь, интервал допустимых значений 0 до 59,необходимо организовать проверкуна ввод 
допустимого интервала. Определите вкакую  четверть часа попадает значение переменной (в 
первую, вторую ,третью или четвертую).  
*/

MinuteInput:
Console.WriteLine("Введите число от 0 до 59");
int min = int.Parse(Console.ReadLine());
if (min < 0 || min > 59)
{
    Console.WriteLine("Введено недопустимое значение! Введите число от 0 до 59");
    goto MinuteInput;
}

  switch (min)
    {
        case <= 15:
            Console.WriteLine("Первая четверть часа");
            break;
        case <= 30:
            Console.WriteLine("Вторая четверть часа");
            break;
        case <= 45:
            Console.WriteLine("Третья четверть часа");
            break;
        case <= 59:
            Console.WriteLine("Четвертая четверть часа");
            break;
    }

Console.ReadKey();
