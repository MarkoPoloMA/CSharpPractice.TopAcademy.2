using System;

namespace CSharpPractice.TopAcademy
{
	internal class FourTask
    {
		public void _FourTask()
		{
			Console.WriteLine("Введите шестизначное число");
			string value = Console.ReadLine();

			if (value.Length != 6)
			{
				Console.WriteLine("Вы ввели не шестизначное число");
				return;
			}

			Console.WriteLine("Введите два разряда для замены");
			string valueStr = Console.ReadLine();
			var strings = valueStr.Split(' ');

			if (strings.Length != 2)
			{
				Console.WriteLine("Вы ввели не два разряда");
				return;
			}

			if (!int.TryParse(strings[0], out int celResul1) ||
				!int.TryParse(strings[1], out int celResul2))
			{
				Console.WriteLine("Ошибка введенных разрядов.");
				return;
			}

			if (celResul1 < 1 || celResul1 > 6 || celResul2 < 1 || celResul2 > 6)
			{
				Console.WriteLine("Вы ввели не те разряды");
				return;
			}

			char[] charArray = value.ToCharArray();

			int valueBeforeSwap = int.Parse(new string(Swap(charArray, celResul1, celResul2)));

			Console.WriteLine(valueBeforeSwap);
			Console.ReadKey();
        }
		private char[] Swap(char[] str, int indexLeft, int indexRight)
		{
			char temp = str[indexLeft - 1];
			str[indexLeft - 1] = str[indexRight - 1];
			str[indexRight - 1] = temp;

			return str;
		}
    }
}
