using System.Text;

namespace Assignment7._1._2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Please type in another word to have these 2 words merge: ");
            string word2 = Console.ReadLine();
            Console.Write("This is the word merged together: ");
            Arraymethod(word1, word2);
        }

        static void Arraymethod(string word1, string word2)
        {
            int wordLength1 = word1.Length;
            int wordLength2 = word2.Length;
            int wordsCombined = wordLength1+wordLength2;

            StringBuilder MergeWords = new();
            
            for (int i = 0; i < wordsCombined; i++)
            {
                if (i < word1.Length)
                {
                    MergeWords.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    MergeWords.Append(word2[i]);
                }
            }
            Console.Write(MergeWords.ToString());

        }
    }
}
