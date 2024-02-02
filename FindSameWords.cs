using System.Text;

namespace Longest_Common_Prefix
{
    public class FindSameWords : IFindSameWords
    {
        public string[] GetStrInputs() {
            List<string> inputs = new List<string>();
            Console.WriteLine("Do you want add more item ? Enter 'Y' for yes and 'N' for no");
            string Condition = Console.ReadLine();
            while (Condition=="Y") { 
                inputs.Add(Console.ReadLine());
                Console.WriteLine("Do you want add more item ? Enter 'Y' for yes and 'N' for no");
                Condition = Console.ReadLine();
            }
            string[] strs = inputs.ToArray();
            return strs;
        }
        public string? SameWords(string[] strs)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < strs[0].Length; i++)
            {
                char currentChar = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || currentChar != strs[j][i])
                    {
                        
                        return output.ToString();
                    }
                }

                output.Append(currentChar);
            }

            return output.ToString();
        }
    }
}
