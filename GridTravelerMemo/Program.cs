// gridTraveler(1, 1) => 1

int gridTraveler(int m, int n, Dictionary<(int, int), int> memo)
{
    if (m == 1 && n == 1) return 1;
    if (m == 0 || n == 0) return 0;

    if (memo.TryGetValue((m, n), out int value) || memo.TryGetValue((n, m), out value))
        return value;

    value = gridTraveler(m - 1, n, memo) + gridTraveler(m, n - 1, memo);
    memo[(m, n)] = value;

    return value;
}