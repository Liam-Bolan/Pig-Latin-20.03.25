using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pig_Latin_20._03._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input phrase: ");
            string phrase = Console.ReadLine();
            string pigLatinPhrase = ConvertToPigLatin(phrase);
            Console.WriteLine("\nPig Latin: " + pigLatinPhrase);
            Console.ReadLine();
        }

        static string ConvertToPigLatin(string phrase)
        {
            string[] words = phrase.Split(' ');
            string vowels = "aeiouAEIOU";
            string result = "";

            foreach (string word in words)
            {
                if (vowels.Contains(word[0])) // Starts with a vowel
                {
                    result += word + "way ";
                }
                else // Starts with a consonant
                {
                    int firstVowelIndex = -1;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (vowels.Contains(word[i]))
                        {
                            firstVowelIndex = i;
                            break;
                        }
                    }
                    if (firstVowelIndex == -1) // No vowels found
                    {
                        result += word + "ay ";
                    }
                    else
                    {
                        string prefix = word.Substring(0, firstVowelIndex);
                        string rest = word.Substring(firstVowelIndex);
                        result += rest + prefix + "ay ";
                    }
                }
            }

            return result.Trim(); // Remove trailing space
        }

    }
}


