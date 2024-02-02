namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindSameWords findSameWords = new FindSameWords();
            string res = findSameWords.SameWords(findSameWords.GetStrInputs());

            Console.WriteLine(res);
        }
    }
}
