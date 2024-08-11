using System;

namespace CSharpPractice.TopAcademy
{

	class Third
	{
		public void _Third()
		{
			try
			{
				Console.WriteLine("Введите 4 числа: ");
				var str = Console.ReadLine();

				var strings = str.Split(' ');

				if (strings.Length != 4)
					throw new ArgumentException("Вы ввели не 4 числа");

				int[] values = new int[4];
				int result = 0;
				for (int i = 0; i < 4; i++)
				{
					if (!int.TryParse(strings[i], out values[i]))
						throw new ArgumentException("Вы ввели не переменные типа int");

					result = result * 10 + values[i];
				}

				Console.WriteLine(result);
				Console.ReadKey();
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
				Console.ReadKey();
			}
		}
	}
}