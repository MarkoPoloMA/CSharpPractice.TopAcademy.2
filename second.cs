using System;

namespace CSharpPractice.TopAcademy;

class Second
{
    public static void _Second()
    {
        try
        {
            Console.WriteLine(
                "Введите два числа: . Первое число — это значение, второе число процент, который");
            var str = Console.ReadLine();
            var strings = str.Split(' ');
            if (strings.Length != 4)
                throw new ArgumentException("Вы ввели не 4 числа");

            if (!int.TryParse(strings[0], out int valueResult) ||
                !int.TryParse(strings[1], out int value2Result))
                throw new ArgumentException("Вы ввели не переменные типа int");

            if (valueResult < 1 && valueResult > 100 || value2Result < 1 && value2Result > 100)
                throw new ArgumentException("Число больше 100 или меньше 1");

            decimal percentDecimal = (valueResult * value2Result) / 100.0m;

            Console.WriteLine($"{value2Result} от числа {valueResult} равно {percentDecimal}");
            Console.ReadKey();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
        catch (FormatException)
        {
            Console.WriteLine("Числа не того формата");
            Console.ReadKey();
        }
    }
}