using System;
using System.Collections.Generic;
using System.Linq;

namespace Factorial;

public class Program
{
	public static void Main(string[] args)
	{
		try
		{
			int result = Factorial(int.Parse(args[0]));
			Console.WriteLine(result);
		}
		catch(Exception exception)
		{
			Console.WriteLine(exception.ToString());
		}
	}
	
	public static int Factorial(int n)
	{
		if(n == 0)
			return 1;
		
		int[] numbers = new int[n];
		numbers = Enumerable.Range(1, n).ToArray();
		return numbers.Aggregate(1, (product, next) => product = product * next);
	}
}