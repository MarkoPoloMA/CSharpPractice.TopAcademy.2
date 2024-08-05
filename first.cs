using System;

namespace CSharpPractice.TopAcademy;

class first
{
    public void First()
    {
        Console.WriteLine("Введи число от 1 до 100: ");

        try
        {
            var value = int.Parse(Console.ReadLine());

            if (value < 1 && value > 100)
                throw new ArgumentException("Число больше 100 или меньше 1");

            if (value % 3 == 0)
                Console.WriteLine("Fizz");
            else if
                (value % 5 == 0) Console.WriteLine("Buzz");
            else if ((value % 5 == 0) && (value % 3 == 0))
                Console.WriteLine("Buzz Fizz");

            Console.ReadKey();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
        catch (FormatException)
        {
            Console.WriteLine("Число не того формата");
            Console.ReadKey();
        }
    }
}