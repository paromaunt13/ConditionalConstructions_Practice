/*
 Создать программу, которая запрашивает имя пользователя и здоровается с ним. 
Для вывода информации использовать 3 варианта конкатенации строк.
*/

Console.WriteLine("Введите Ваше имя:");
string name = Console.ReadLine();

string welcome = "Добро пожаловать, ";
string greeting = welcome + name;

Console.WriteLine(greeting);
Console.WriteLine(string.Concat("Добро пожаловать, ", name));
Console.WriteLine(welcome + name);
