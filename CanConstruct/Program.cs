bool CanConstruct(string target, string[] wordBank, Dictionary<string, bool> memo)
{
    if (memo.TryGetValue(target, out bool value)) return value;
    if (target == "") return true;
    foreach (var word in wordBank)
    {
        if (target.StartsWith(word))
        {
            var suffix = target.Substring(word.Length);
            var canConstructSuffix = CanConstruct(suffix, wordBank, memo);
            if (canConstructSuffix == true)
            {
                memo[target] = true;
                return true;
            }
        }
    }
    memo[target] = false;
    return false;
}


Console.WriteLine(CanConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, new Dictionary<string, bool>()));
Console.WriteLine(CanConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, new Dictionary<string, bool>()));
Console.WriteLine(CanConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, new Dictionary<string, bool>()));
Console.WriteLine(CanConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
    new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }, new Dictionary<string, bool>()));