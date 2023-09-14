using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.Palindrome
{
    class Program
        {
            static bool IsPalindrome(string Number)
            {
                int length = Number.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (Number[i] != Number[length - i - 1])
                    {
                        return false;
                    }
                }
                return true;
            }

            static void Main()
            {
                Console.Write("Enter a Palindrome: ");
                string EnterNumber = Console.ReadLine();


                if (IsPalindrome(EnterNumber))
                {
                    Console.WriteLine(EnterNumber + " is a Palindrome.");
                }
                else
                {
                    Console.WriteLine(EnterNumber + " is not a palindrome.");
                }
                Console.ReadLine();
                {
                }
            }
        }
    }