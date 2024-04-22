namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<char, List<string>> myDictionary = new Dictionary<char, List<string>>();
            myDictionary['a'] = new List<string> { "about","accept","academic"};
            myDictionary['b'] = new List<string> { "baby", "back", "boat" };
            myDictionary['c'] = new List<string> { "cake", "calm", "campus" };

            DisplayDictionary(myDictionary);
            myDictionary.Remove('c');
            DisplayDictionary(myDictionary);
        }

        static void DisplayDictionary(Dictionary<char, List<string>> Dictionary)
        {
            Console.WriteLine("Content of the dictionary");
            foreach (var kvp in Dictionary)
            {
                Console.WriteLine($"Letter: {kvp.Key}, Words: {string.Join(", ", kvp.Value)}");
            }
            Console.WriteLine();
        }
    }


}
