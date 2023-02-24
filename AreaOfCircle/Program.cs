/*
Дана длина L окружности. Найти ее радиус R и площадь S круга,
ограниченного этой окружностью, учитывая, что L = 2*Pi*R, S = Pi*R2.
В качестве значения Pi использовать 3.14.
*/

Console.WriteLine("Введите длину окружности:");
int L = int.Parse(Console.ReadLine());

const double pi = Math.PI;

double R = L / 2 * pi;
double S = pi * Math.Pow(R, 2);

Console.WriteLine($"Радиус окружности - {R}, площадь круга - {S}");
Console.ReadKey();
