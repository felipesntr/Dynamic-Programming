int CountConstruct(string target, string[] wordBank, Dictionary<string, int> memo)
{
    if (memo.TryGetValue(target, out int value)) return value;
    if (target == "") return 1;
    int count = 0;
    foreach (var word in wordBank)
    {
        if (target.StartsWith(word))
        {
            var suffix = target.Substring(word.Length);
            count += CountConstruct(suffix, wordBank, memo);
        }
    }
    memo[target] = count;
    return count;
}


Console.WriteLine(CountConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd", "cdef" }, new Dictionary<string, int>()));
Console.WriteLine(CountConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" }, new Dictionary<string, int>()));
Console.WriteLine(CountConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, new Dictionary<string, int>()));
Console.WriteLine(CountConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, new Dictionary<string, int>()));
Console.WriteLine(CountConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
    new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }, new Dictionary<string, int>()));