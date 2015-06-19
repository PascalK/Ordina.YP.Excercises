using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordina.YP.PriemGetal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            do
            {
                string enteredNumber;
                int numberToCheck;
                List<int> dividables;
                bool isPriemgetal;

                Console.Write("Geef een getal: ");
                enteredNumber = Console.ReadLine();
                numberToCheck = int.Parse(enteredNumber);
                isPriemgetal = IsPrime(numberToCheck, out dividables);
                if (isPriemgetal)
                {
                    Console.WriteLine("{0} is WEL een priemgetal", enteredNumber);
                }
                else
                {
                    Console.WriteLine("{0} is GEEN een priemgetal", enteredNumber);
                    Console.WriteLine("  because is can be divided by:", enteredNumber);
                    foreach (int dividable in dividables)
                    {
                        Console.WriteLine("  {0}", dividable);
                    }
                }

                Console.Write("Wilt u nog een woord opgegeven (j)? ");
                keepGoing = Console.ReadLine().ToLowerInvariant() == "j";
            }
            while (keepGoing);
        }
        private static bool IsPrime(int enteredNumber, out List<int> canBeDevidedBy)
        {
            canBeDevidedBy = new List<int>();
            bool isPriemgetal = true;

            for (int i = 2; i < enteredNumber; i++)
            {
                if ((enteredNumber % i) == 0)
                {
                    isPriemgetal = false;
                    canBeDevidedBy.Add(i);
                }
            }
            return isPriemgetal;
        }
    }
}