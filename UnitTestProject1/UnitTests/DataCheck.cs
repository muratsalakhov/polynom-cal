using System;
using System.Text.RegularExpressions;

static public class DataCheck
{

	static public bool polynomCheck(string polynom)
	{
		//string polynomPattern = @"^((([0-9]*[x]?[^][0-9]*)?[+,-]{1}([0-9]*[x]?[^][0-9]*)?)*([+,-][0-9]*)?){1}$";
		//string polynomPattern = @"^((?<value>[+-^][\d\.,]*)?x?\^?(?<pow>\d)*)+$";
		Regex regex = new Regex(@"^((?<value>[+-^][\d\.,]*)?x?\^?(?<pow>\d)*)+$");

		Console.WriteLine(regex.IsMatch(polynom));

		if (polynom.Length > 0 && regex.IsMatch(polynom))
		{
			Console.WriteLine("Строка является полиномом");
			return true;
		}
		else
		{
			Console.WriteLine("Строка не является полиномом");
			return false;
		}
	}

	static public bool argumentCheck(string argument)
	{
		string argumentPattern = @"^[+,-]?[0-9]+$";

		if (argument.Length > 0 && Regex.IsMatch(argument, argumentPattern, RegexOptions.IgnoreCase))
		{
			Console.WriteLine("Строка является аргументом");
			return true;
		}
		else
		{
			Console.WriteLine("Строка не является аргументом");
			return false;
		}
	}
}
