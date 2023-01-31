using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Project
{
    class Palindrome
    {
      public  static bool IsPalindrome(string text)
        {
            string result = "";
            text = text.ToLower();

            if (text.Contains(" "))
            {
                text = text.Replace(" ", "");
            }

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }

            return result == text;
        }

        public static bool IsPalindrome2(string text)
        {
            text = text.ToLower();
            bool flag = false;
            text = text.Replace(" ", "");

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] == text[text.Length -1 -i])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }

        public static bool IsPalindromeNumber(int n)
        {
            string convertedNumber = n.ToString();

            return IsPalindrome(convertedNumber);
        }

        public static bool IsPalindromeNumber2(int n)
        {
            int temp = n;
            int result = 0;
            int lastDigit;

            while (n > 0)
            {
                lastDigit = n % 10;
                result = result * 10 + lastDigit;
                n /= 10;
            }

            return temp == result;
        }
    }
}
