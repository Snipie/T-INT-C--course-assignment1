using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main(string[] args)
  {
	try
	{
		Console.WriteLine(Fibonacci(int.Parse(args[0])));
	}
    catch(Exception exception)
	{
		Console.WriteLine(exception.ToString());
	}
  }

  public static int Fibonacci(int n)
  {
    if(n <= 1)
      return n;

    List<int> series = Enumerable.Range(0, n).ToList();

    series = (from num in series where num < 3 select num > 1 ? series[0] + series[1] : num).ToList();
    series.Reverse();
    
    for(int i = 3; i <= n; i++)
      series = series.Prepend(series.Take(2).Sum()).ToList();

    return series.First();
  }

  public static void PrintEnumerable<T>(IEnumerable<T> e)
  {
    foreach(object obj in e)
      Console.WriteLine(obj);
  }
}