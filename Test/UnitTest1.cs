using System.Linq;

namespace Test;

public class UnitTest1
{
    private int LIMIT = 20;

    [Fact]
    public void FibonacciTest()
    {
        List<int> expected = new List<int>();
        List<int> toBeTested = new List<int>();
        for(int i = 0; i <= LIMIT; i++)
        {  
            expected.Add(ValidFibonacci(i));
            toBeTested.Add(Fibonacci.Program.Fibonacci(i));
        }
        
        Assert.Equal(expected, toBeTested);
    }

    [Fact]
    public void FactorialTest()
    {
        List<int> expected = new List<int>();
        List<int> toBeTested = new List<int>();
        for(int i = 0; i <= LIMIT; i++)
        {
            expected.Add(ValidFactorial(i));
            toBeTested.Add(Factorial.Program.Factorial(i));
        }
        
        Assert.Equal(expected, toBeTested);
    }

    public int ValidFibonacci(int n)
    {
        if(n < 2)
            return n;

        List<int> series = new List<int>(){0, 1};
        series.AddRange(Enumerable.Repeat(0, n - 1));
        for(int i = 2; i <= n; i++)
           series[i] = series[i - 2] + series[i - 1];

        return series[n];
    }

    public int ValidFactorial(int n)
    {
        int result = 1;
        for(int i = 1; i <= n; i++)
            result *= i;
   
        return result;
    }
}