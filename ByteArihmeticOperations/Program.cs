/*
 Дано 2 числа, а = 10, b = 20.
Написать программу, которая выполняет сложение данных чисел, вычитание, умножение, деление, получения остатка от деления, 
переменные которые хранят результат данных операция должны быть типа byte. 
Результат выполнения программы вывести на Console.
*/

int a = 10, b = 20;

byte addition = (byte)(b + a);
byte subtract = (byte)(b - a);
byte division = (byte)(b / a);
byte multiply = (byte)(b * a);
byte leftover = (byte)(b % a);

Console.WriteLine($"Результат сложения {b} и {a} равен {addition}");
Console.WriteLine($"Результат вычитания {b} и {a} равен {subtract}");
Console.WriteLine($"Результат умножения {b} и {a} равен {multiply}");
Console.WriteLine($"Результат деления {b} и {a} равен {division}");
Console.WriteLine($"Результат получения остатка от деления деления {b} и {a} равен {leftover}");

Console.ReadKey();
