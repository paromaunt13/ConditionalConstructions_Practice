﻿/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. 
Если да, то укажите, в какой именно промежуток. 
Если пользователь указывает число не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 0 && number <= 100)
{
    switch (number)
    {
        case < 15:
            Console.WriteLine("Введеное число в промежутке от 0 до 14");
            break;
        case < 36:
            Console.WriteLine("Введеное число в промежутке от 15 до 35");
            break;
        case < 50:
            Console.WriteLine("Введеное число в промежутке от 36 до 50");
            break;
        case <= 100:
            Console.WriteLine("Введеное число в промежутке от 51 до 100");
            break;
    }
}
else Console.WriteLine("Введенное число не входит ни в один из имеющихся числовых промежутков");

Console.ReadKey();