/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу русско-английский переводчик. Программа знает 10 слов о погоде.
Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
*/

Console.WriteLine("Введите слово о погоде (с большой буквы): ");
string word = Console.ReadLine();

switch (word)
{
    case "Мороз":
        Console.WriteLine($"Перевод слова {word} - freezing");
        break;
    case "Холод":
        Console.WriteLine($"Перевод слова {word} - cold");
        break;
    case "Тепло":
        Console.WriteLine($"Перевод слова {word} - warm");
        break;
    case "Жара":
        Console.WriteLine($"Перевод слова {word} - heat");
        break;
    case "Дождь":
        Console.WriteLine($"Перевод слова {word} - rain");
        break;
    case "Снег":
        Console.WriteLine($"Перевод слова {word} - snow");
        break;
    case "Туман":
        Console.WriteLine($"Перевод слова {word} - fog");
        break;
    case "Облачно":
        Console.WriteLine($"Перевод слова {word} - cloudy");
        break;
    case "Ясно":
        Console.WriteLine($"Перевод слова {word} - fair weather");
        break;
    case "Гроза":
        Console.WriteLine($"Перевод слова {word} - thunderstorm");
        break;
    default: 
        Console.WriteLine("Перевод для этого слова не найден");
        break;
}
Console.ReadKey();