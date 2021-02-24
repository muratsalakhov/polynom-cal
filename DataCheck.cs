using System;

static public class DataCheck
{
	static public DataCheck()
	{
	}

	static public bool polynomCheck(string polynom)
    {
		string polynomPattern = @"^((([0-9]*[x,y]{1}[0-9]*)?[+,-]{1}([0-9]*[x,y]{1}[0-9]*)?)*([+,-][0-9]*)?){1}$";
		
		if (polynom.Length > 0 && Regex.IsMatch(polynom, polynomPattern, RegexOptions.IgnoreCase))
        {
			Console.WriteLine("Строка является полиномом");
			return true;
        } else
        {
			Console.WriteLine("Строка не является полиномом");
			return false;
        }
	}

	static public bool argumentCheck(string argument)
    {
		string argumentPattern = @"^[0-9]+$";

		if (polynom.Length > 0 && Regex.IsMatch(argument, argumentPattern, RegexOptions.IgnoreCase))
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
