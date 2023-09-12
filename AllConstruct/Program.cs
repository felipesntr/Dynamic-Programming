List<List<string>>? allConstruct(string target, string[] wordBank)
{
    //if (memo.TryGetValue(target, out int value)) return value;
    if (target == "") return new();

    List<List<string>>? construct;

    foreach (var word in wordBank)
    {
        
    }

    return new();
}


Console.WriteLine(AllConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd", "cdef" }));
Console.WriteLine(AllConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" }));
Console.WriteLine(AllConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
Console.WriteLine(AllConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }));
Console.WriteLine(AllConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
    new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }));