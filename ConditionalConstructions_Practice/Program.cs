/*
 Используя Visual Studio,создайте проект по шаблону Console Application.                                                 
Напишите программу, вкоторой создайте переменную a. Значение переменной, а должен задавать 
пользователь. Если а < 10 то выведите 'Верно', иначе  (a>10) выведите 'Неверно'. 
*/

Console.WriteLine("Введите значение:");
int a = int.Parse(Console.ReadLine());

string result = a < 10 ? "Верно" : "Неверно";
Console.WriteLine(result);

Console.ReadKey();