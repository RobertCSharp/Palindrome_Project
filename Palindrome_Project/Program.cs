using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome.IsPalindrome("Rotator"));  // true
            Console.WriteLine(Palindrome.IsPalindrome("Rotation")); // false
            Console.WriteLine(Palindrome.IsPalindrome("never odd or even")); // true

            Console.WriteLine(Palindrome.IsPalindrome2("Rotator")); // true
            Console.WriteLine(Palindrome.IsPalindrome2("Rotation")); // false
            Console.WriteLine(Palindrome.IsPalindrome2("never odd or even")); // true

            Console.WriteLine(Palindrome.IsPalindromeNumber(1331)); // true
            Console.WriteLine(Palindrome.IsPalindromeNumber(1371)); // false

            Console.WriteLine(Palindrome.IsPalindromeNumber2(1331)); // true
            Console.WriteLine(Palindrome.IsPalindromeNumber2(1371)); // false

            Console.ReadKey();
        }
    }
}
