using System;

static public class CalcModule
{
	static public CalcModule()
	{
	}

	static public int polynomCalc(/*string polynom, string argument*/)
    {
		string polynom = "+3x5+2x4+5x2+8";
		Regex regex = new Regex(@"[+,-][^+,-]+");
		MatchCollection matches = regex.Matches(polynom);
		foreach (Match match in matches)
        {
			Console.WriteLine(match.Value);
        }
	}
}
