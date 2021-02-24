using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

static public class CalcModule
{

	static public int polynomCalc(string polynom, string argument)
	{
		//string polynom = "3x5+2x4+5x2+8";

		Dictionary<int, int> termMap = new Dictionary<int, int>();


		foreach (Match match in Regex.Matches(polynom, @"(?<value>[+-^][\d\.,]*)?x?\^?(?<pow>\d)*"))
		{
			if (match.Value!="")
			{
				int value;
				int pow;

				if (!int.TryParse(match.Groups["value"].Value, out value))
				{
					value = 1;
				}
				if (!int.TryParse(match.Groups["pow"].Value, out pow))
				{
					pow = match.Value.Contains("x") ? 1 : 0;
				}
				Console.WriteLine(match);
				Console.WriteLine(pow + " " + value);
				termMap.Add(pow, value);

			}
			
		}

		int result = 0;
		foreach (var term in termMap)
		{
			result += term.Value * (int)(Math.Pow(int.Parse(argument), term.Key));
		}

		return result;
	}

	static public long expressionCalc(string polynomP, string argumentX, string polynomQ, string argumentY)
    {
		long result = polynomCalc(polynomP, argumentX) * polynomCalc(polynomQ, argumentY) - polynomCalc(polynomP, "" + polynomCalc(polynomQ, "" + (int.Parse(argumentX) + int.Parse(argumentY))));
		Console.WriteLine(result);
		return result;

	}
}
