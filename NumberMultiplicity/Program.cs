/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой пользователь вводит целое число. 
Программа в свою очередь должна ответить, 
четным или нечетным является это число, делится ли оно на 3 и делится ли оно на 6.
*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0 && number % 3 == 0)
{
    Console.WriteLine("Число является четным, делится на 3 и 6");
}
else if (number % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else if (number % 3 == 0)
{
    Console.WriteLine("Число является нечетным и делится на 3");
}
else Console.WriteLine("Число является нечетным");

Console.ReadKey();
