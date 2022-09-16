using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci;

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

    List<int> series = new List<int>();
    series.AddRange(Enumerable.Repeat(0, n - 1));

    List<int> seed = new List<int>(){0, 1};

    series = series.Select<int, int>(s => {s = seed.TakeLast(2).Sum(); seed.Add(s); return s;}).ToList();

    return series.Last();
  }

  public static void PrintEnumerable<T>(IEnumerable<T> e)
  {
    foreach(object obj in e)
      Console.WriteLine(obj);
  }
}