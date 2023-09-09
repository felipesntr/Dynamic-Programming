using System.Numerics;
// Console.WriteLine($"{Fib(50)}");


int Fib(int n)
{
    if (n <= 2) return 1;
    return Fib(n - 1) + Fib(n - 2);
}

// Memoization

BigInteger FibMemo(BigInteger n, Dictionary<BigInteger, BigInteger> memo)
{
    if (memo.ContainsKey(n))
        return memo[n];

    if (n <= 2) return 1;
    memo.Add(n, FibMemo(n - 1, memo) + FibMemo(n - 2, memo));
    return memo[n];
}

Console.WriteLine($"{FibMemo(500, new Dictionary<BigInteger, BigInteger>())}");