/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
Напишите программу расчета начисления премий сотрудникам. 
Премии рассчитываются согласно выслуге лет. 
Если выслуга до 5 лет, премия составляет 10% от заработной платы. 
Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы. 
Если выслуга от 10 лет (включительно) до 15 лет, премия составляет 25% от заработной платы. 
Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной платы. 
Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы. 
Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной платы. 
Результаты расчета, выведите на экран.
*/

Console.WriteLine("Введите Вашу выслугу лет: ");
int years = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер Вашей заработной платы, грн: ");
int salary = int.Parse(Console.ReadLine());

float premiumAmount = 0;

if (years > 0)
{
    switch (years)
    {
        case < 5:
            premiumAmount = 0.1f;
            break;
        case < 10:
            premiumAmount = 0.15f;
            break;
        case < 15:
            premiumAmount = 0.25f;
            break;
        case < 20:
            premiumAmount = 0.35f;
            break;
        case < 25:
            premiumAmount = 0.45f;
            break;
        case >= 25:
            premiumAmount = 0.50f;
            break;            
    }
}

salary += (int)(salary * premiumAmount);
Console.WriteLine($"\tРазмер Вашей премии составляет {premiumAmount:P0} \n\tРазмер Вашей заработной платы с премией составляет {salary} грн.");

Console.ReadKey();

