bool canSum(int targetSum, int[] arr, Dictionary<int, bool> memo)
{
    if (memo.TryGetValue(targetSum, out bool value))
        return value;
    if (targetSum == 0) return true;
    if (targetSum < 0) return false;
    for (int i = 0; i < arr.Count(); i++)
    {
        var remainder = targetSum - arr[i];
        if (canSum(remainder, arr, memo) == true)
        {
            memo[targetSum] = true;
            return true;
        }
    }
    memo[targetSum] = false;
    return false;
}

Console.WriteLine(canSum(30000, new int[] { 5, 3, 7 }, new Dictionary<int, bool>())); // true