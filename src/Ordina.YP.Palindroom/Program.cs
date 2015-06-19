using System;

namespace Ordina.YP.Palindroom
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            do
            {
                string enteredWord;
                bool isPalindroom1;
                bool isPalindroom2;
                
                Console.Write("Geef een woord: ");
                enteredWord = Console.ReadLine();

                isPalindroom1 = IsPalindroom_WithLoop(enteredWord);
                isPalindroom2 = IsPalindroom_WithFunctions(enteredWord);
                PrintIsPalindroom(isPalindroom1, enteredWord);
                PrintIsPalindroom(isPalindroom2, enteredWord);
                
                Console.Write("Wilt u nog een woord opgegeven (j)? ");
                keepGoing = Console.ReadLine().ToLowerInvariant() == "j";
            }
            while (keepGoing);
        }

        private static bool IsPalindroom_WithLoop(string wordToCheck)
        {
            bool isPalindroom;

            isPalindroom = true;
            for (int i = 0; i < wordToCheck.Length; i++)
            {
                if (wordToCheck[i] != wordToCheck[wordToCheck.Length - i - 1])
                {
                    isPalindroom = false;
                    break;
                }
            }

            return isPalindroom;
        }
        private static bool IsPalindroom_WithFunctions(string wordToCheck)
        {
            bool isPalindroom;
            string wordToCheckReversed;
            char[] wordCharacters; 
            
            wordCharacters = wordToCheck.ToCharArray();
            Array.Reverse(wordCharacters);
            wordToCheckReversed = string.Concat(wordCharacters);
            isPalindroom = (wordToCheck == wordToCheckReversed);

            return isPalindroom;
        }

        private static void PrintIsPalindroom(bool isPalindroom, string word)
        {
            if (isPalindroom)
            {
                System.Console.WriteLine("{0} is WEL een palindroom", word);
            }
            else
            {
                System.Console.WriteLine("{0} is GEEN een palindroom", word);
            }
        }
    }
}
