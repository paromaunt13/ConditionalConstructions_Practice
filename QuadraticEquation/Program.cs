/* 
 Используя Visual Studio, создайте проект по шаблону Console Application.
 Напишите программу,  которая решает квадратное уравнение. 
 Пользователь должен ввести коэффициенты а, b и с квадратного уравнения ах2 + bх + с = 0. 
 После чего программа должна вывести на экран все корни этого уравнения или сообщение о том, что их нет. 
 Рассмотреть случаи когда дискриминант (D) квадратного уравнения > 0, когда D<0 и когда D = 0.
 */

int a, b, c, x, x_1, x_2;
Console.WriteLine("Введите коэффициент квадратного уравнения a: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициент квадратного уравнения b: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициент квадратного уравнения c: ");
c = int.Parse(Console.ReadLine());

int squareB = (int)Math.Pow(b, 2);
int discriminant = squareB - 4 * a * c;

if (discriminant > 0)
{
    x_1 = (b * -1) + (int)Math.Sqrt(discriminant) / 2 * a;
    Console.WriteLine($"Первый корень уравнения - {x_1}");
    x_2 = (b * -1) - (int)Math.Sqrt(discriminant) / 2 * a;
    Console.WriteLine($"Второй корень уравнения - {x_2}");
}
else if (discriminant == 0)
{
    x = (b * -1) / 2 * a;
    Console.WriteLine($"Корень уравнения - {x}");
}
else
{
    Console.WriteLine("Корни уравнения не определены");
}

Console.ReadKey();

