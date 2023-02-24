/*
Используя Visual Studio,создайтепроектпо шаблону Console Application.                                               
Напишите программу, которая будет рассчитывать процент скидки в зависимости от количества 
купленного товара. Если куплено больше 3 единиц товара, тогда скидка должна быть 10 процентов 
от общей суммы, если же количество больше 3 и меньше 7, то 20 процентов от общей суммы, иначе, 
если больше 7 то 25 процентов от общей суммы. Цену товара и купленное количество товара 
пользователь должен задавать вводом с консоли.
*/

Console.WriteLine("Введите количество товара, шт.: ");
int productAmount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите цену товара за 1 шт, грн.: ");
int productPrice = int.Parse(Console.ReadLine());

float discount;
if (productAmount > 0 && productAmount < 3)
    discount = 0.1f;
else if (productAmount > 3 && productAmount < 7)
    discount = 0.2f;
else discount = 0.25f;

float discountAmount = productPrice * productAmount * discount;
float totalPrice = productAmount * productPrice - discountAmount;

Console.WriteLine($"Размер скидки за {productAmount} шт. товара составляет {discount:P0} \nОбщая стоимость товара: {totalPrice} грн.");






