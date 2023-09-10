List<int>? bestSum(int targetSum, List<int> numbers, Dictionary<int, List<int>> memo)
{
    if (memo.TryGetValue(targetSum, out List<int> value))
        return value;
    if (targetSum == 0) return new();
    if (targetSum < 0) return null;
    List<int>? shortestCombination = null;
    foreach (int num in numbers)
    {
        var remainder = targetSum - num;
        var remainderCombination = bestSum(remainder, numbers, memo);
        if (remainderCombination != null)
        {
            var combination = new List<int>(remainderCombination) { num };
            // if the combination is shorter tha the current "shortest", update it;
            if (shortestCombination == null || combination.Count < shortestCombination.Count)
            {
                shortestCombination = combination;
            }
        }
    }
    memo[targetSum] = shortestCombination;
    return shortestCombination;
}


bestSum(7, new List<int> { 5, 3, 4, 7, 2 }, new Dictionary<int, List<int>>()).ForEach(x => Console.Write($"{x} "));
Console.WriteLine($"");
bestSum(8, new List<int> { 2, 3, 5 }, new Dictionary<int, List<int>>()).ForEach(x => Console.Write($"{x} "));
Console.WriteLine($"");
bestSum(8, new List<int> { 1, 4, 5, 1 }, new Dictionary<int, List<int>>()).ForEach(x => Console.Write($"{x} "));
Console.WriteLine($"");
bestSum(100, new List<int> { 2, 5, 25, 1 }, new Dictionary<int, List<int>>()).ForEach(x => Console.Write($"{x} "));
