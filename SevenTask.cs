using System;
using System.Linq;

namespace CSharpPractice.TopAcademy
{
    class SevenTask
    {
		public void _SevenTask()
		{
			Console.WriteLine("Введите первое число:");
			if (!int.TryParse(Console.ReadLine(), out int start))
			{
				Console.WriteLine("Ошибка ввода первого числа.");
				return;
			}

			Console.WriteLine("Введите второе число:");
			if (!int.TryParse(Console.ReadLine(), out int end))
			{
				Console.WriteLine("Ошибка ввода второго числа.");
				return;
			}

			if (start > end)
				(start, end) = (end, start);
			foreach (var i in Enumerable.Range(start, end - start + 1).Where(x => x % 2 == 0))
				Console.WriteLine(i);
		}
	}
}
