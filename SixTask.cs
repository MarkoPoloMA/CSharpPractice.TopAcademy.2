using System;

namespace CSharpPractice.TopAcademy
{
	internal class SixTask
    {
		public void _SixTask()
		{
			Console.WriteLine("Введите показания температуры:");
			double temp = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Выберите направление преобразования:");
			Console.WriteLine("1. Фаренгейт -> Цельсий");
			Console.WriteLine("2. Цельсий -> Фаренгейт");

			int choice = int.Parse(Console.ReadLine());
			double result;

			if (choice == 1)
			{
				result = FahrenheitToCelsius(temp);
				Console.WriteLine($"{temp} градусов по Фаренгейту = {result} градусов по Цельсию");
			}
			else if (choice == 2)
			{
				result = CelsiusToFahrenheit(temp);
				Console.WriteLine($"{temp} градусов по Цельсию = {result} градусов по Фаренгейту");
			}
			else
			{
				Console.WriteLine("Некорректный выбор.");
			}
		}
		private double FahrenheitToCelsius(double feren)
		{
			return (feren - 32) * 5 / 9;
		}

		private double CelsiusToFahrenheit(double cels)
		{
			return cels * 9 / 5 + 32;
		}
	}
}
