List<int>? howSum(int targetSum, List<int> numbers, Dictionary<int, List<int>> memo)
{
    if (targetSum == 0) return new();
    if (targetSum < 0) return null;
    if (memo.TryGetValue(targetSum, out List<int> value))
        return value;
    foreach (int num in numbers)
    {
        var remainder = targetSum - num;
        var remainderResult = howSum(remainder, numbers, memo);
        if (remainderResult != null)
        {
            remainderResult.Add(num);
            memo[targetSum] = remainderResult;
            return remainderResult;
        }
    }
    memo[targetSum] = null;
    return null;
}

var result = howSum(65784, new List<int> { 134, 123, 12, 7, 867 }, new Dictionary<int, List<int>>());

result.ForEach(x => Console.Write($"{x} "));
