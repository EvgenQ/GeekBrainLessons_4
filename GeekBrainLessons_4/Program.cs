using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainLessons_4
{
	class Program
	{
		static string GetFullName(string firstName, string lastName, string patroNymic)
		{
			string a = " ";
			string fullName = lastName + a + firstName + a + patroNymic;
			return fullName;
		}// Метод к заданию №1

		static string GetFullNameNew()
		{
			Console.WriteLine("Введите имя");
			string firstName = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Введите фамилию");
			string lastName = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Введите очество");
			string patroNymic = Console.ReadLine();
			Console.Clear();
			string a = " ";
			string fullName = lastName + a + firstName + a + patroNymic;

			return fullName;
		}// Метод к заданию №1( первый вариант)
		static int SumNumberString(string number)
		{
			int sum = 0;
			string[] c = number.Split(' ');
			foreach (var item in c)
			{
				if (item != "")
					sum += int.Parse(item);
			}
			return sum;
		}// Метод к заданию №2

		static void XXX(int numbMounth)
		{
			if ((Mounth)numbMounth == Mounth.December || (Mounth)numbMounth == Mounth.January || (Mounth)numbMounth == Mounth.February)
			{
				TimeYear winter = TimeYear.Winter;
				switch (winter)
				{
					case TimeYear.Winter:
						Console.WriteLine("Это Зима");
						break;
					case TimeYear.Autumn:
						Console.WriteLine("Это Осень");
						break;
					case TimeYear.Spring:
						Console.WriteLine("Это Весна");
						break;
					case TimeYear.Summer:
						Console.WriteLine("Это Лето");
						break;
					default:
						break;
				}
			}
			else if ((Mounth)numbMounth == Mounth.Marth || (Mounth)numbMounth == Mounth.April || (Mounth)numbMounth == Mounth.May)
			{
				TimeYear spring = TimeYear.Spring;
				switch (spring)
				{
					case TimeYear.Winter:
						Console.WriteLine("Это Зима");
						break;
					case TimeYear.Autumn:
						Console.WriteLine("Это Осень");
						break;
					case TimeYear.Spring:
						Console.WriteLine("Это Весна");
						break;
					case TimeYear.Summer:
						Console.WriteLine("Это Лето");
						break;
					default:
						break;
				}
			}
			else if ((Mounth)numbMounth == Mounth.June || (Mounth)numbMounth == Mounth.Jule || (Mounth)numbMounth == Mounth.August)
			{
				TimeYear summer = TimeYear.Summer;
				switch (summer)
				{
					case TimeYear.Winter:
						Console.WriteLine("Это Зима");
						break;
					case TimeYear.Autumn:
						Console.WriteLine("Это Осень");
						break;
					case TimeYear.Spring:
						Console.WriteLine("Это Весна");
						break;
					case TimeYear.Summer:
						Console.WriteLine("Это Лето");
						break;
					default:
						break;
				}
			}
			else if ((Mounth)numbMounth == Mounth.September || (Mounth)numbMounth == Mounth.November || (Mounth)numbMounth == Mounth.October)
			{
				TimeYear autumn = TimeYear.Autumn;
				switch (autumn)
				{
					case TimeYear.Winter:
						Console.WriteLine("Это Зима");
						break;
					case TimeYear.Autumn:
						Console.WriteLine("Это Осень");
						break;
					case TimeYear.Spring:
						Console.WriteLine("Это Весна");
						break;
					case TimeYear.Summer:
						Console.WriteLine("Это Лето");
						break;
					default:
						break;
				}
			}
			else
				Console.WriteLine("Ошибка: введите число от 1 до 12");
		}// Метод к заданию №3

		static int Fibanachi(int n)
		{
			if (n == 0)
				return 0;
			if (n == 1)
				return 1;
			else
				return Fibanachi(n - 1) + Fibanachi(n - 2);
		}//Метод к заданию №4
		enum Mounth
		{
			January = 1,
			February,
			Marth,
			April,
			May,
			June,
			Jule,
			August,
			September,
			October,
			November,
			December,
		}
		enum TimeYear
		{
			Winter,
			Autumn,
			Spring,
			Summer
		}
		static void Main(string[] args)
		{
			{
				// 1 вариант
				Console.WriteLine("Введите ФИО работников");
				string worker = GetFullNameNew();
				string painter = GetFullNameNew();
				string security = GetFullNameNew();
				Console.WriteLine(worker + " - Рабочий\n" + painter + " - Маляр\n" + security + " - Охранник");
				// 2 вариант
				string student1Fn = "Иванов", student1Ln = "Иван", student1P = "Иванович";
				string student2Fn = "Петров", student2Ln = "Петр", student2P = "Петрович";
				string student3Fn = "Сидоров", student3Ln = "Сидр", student3P = "Сидорович";

				string fullNameSt1 = GetFullName(student1Fn, student1Ln, student1P);
				string fullNameSt2 = GetFullName(student2Fn, student2Ln, student2P);
				string fullNameSt3 = GetFullName(student3Fn, student3Ln, student3P);

				Console.WriteLine(fullNameSt1 + "\n" + fullNameSt2 + "\n" + fullNameSt3);

				// или вот так
				Console.WriteLine(GetFullName(student1Fn, student1Ln, student1P));
				Console.WriteLine(GetFullName(student2Fn, student2Ln, student2P));
				Console.WriteLine(GetFullName(student3Fn, student3Ln, student3P));
				Console.ReadLine();
			}// Задание №1

			{
				Console.WriteLine("Введите любое количество чисел(не дробных) через пробел");
				string xxx = Console.ReadLine();

				Console.Write($"Cумма этих чисел {xxx} = {SumNumberString(xxx)}");
				Console.ReadLine();
			}// Задание №2

			{
				Console.Write("Введите номер текущего месяца : ");
				int bbb = int.Parse(Console.ReadLine());
				XXX(bbb);
				Console.ReadLine();
			}// Задание №3

			{
				Console.WriteLine("Введите число");
				int fib = int.Parse(Console.ReadLine());
				Console.WriteLine(Fibanachi(fib));
				Console.ReadLine();
			}// Задание №4


			Console.ReadLine();
		}
	}
}
