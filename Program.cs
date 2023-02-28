Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("яблоко", "это фрукт");
dictionary.Add("кошка", "это животное");
findTheMeaningWord(dictionary);

static void findTheMeaningWord(Dictionary<string, string> dictionary)
{
    string userInput = Console.ReadLine().ToLower();

    if (dictionary.ContainsKey(userInput))
        Console.WriteLine(dictionary[userInput]);
    else
        Console.WriteLine("По запросу ничего не найдено.");
}