using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	public static void Main(string[] args)
	{
		ulong result = Factorial(ulong.Parse(args[0]));
		Console.WriteLine(result);
	}
	
	public static ulong Factorial(ulong n)
	{
		if(n == 0)
			return 1;
		
		ulong[] numbers = new ulong[n];
		numbers = (from num in numbers select numbers[0]++ + 1).ToArray();
		return numbers.Aggregate(1UL, (product, next) => product = product * next);
	}
}