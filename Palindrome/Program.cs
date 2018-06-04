using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string word)
        {
            bool isPalindrome = true;
            int halfLength = (int)Math.Floor(word.Length / 2.0);
            word = word.ToLower();

            for (int i = 0; i < halfLength; i++)
            {

                char first = word[i];
                char second = word[word.Length - 1 - i];

                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }


            }

            return isPalindrome;

        }

        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindrome("Deleveled"));
            Console.ReadKey();

        }

    }
}
