using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to or Palindrome checker! Enter any text that you wish to check: ");
        string userTextStr = Console.ReadLine();
        string userTextNoSpaces = userTextStr.Replace(" ", "");

        bool isPalindrome = CheckPalindromeII(userTextNoSpaces);
        if (isPalindrome) {
            Console.WriteLine(userTextStr + " is a palindrome!");
        } else {
            Console.WriteLine(userTextStr + " is not a palindrome.");
        }
    }

    public static bool CheckPalindrome(string str)
    {
        // split string into an array of characters , then reverse the array
        char[] userTextArr = str.ToCharArray();
        Array.Reverse(userTextArr);

        // join the reversed character array into a reversed string
        string reversedStr = new string(userTextArr);

        // if the reversed string matches the original, it is a palindrome!
        if (str == reversedStr)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CheckPalindromeII(string str)
    {
        char[] arrayedStr = str.ToCharArray();
        
        for (int i = 0; i < arrayedStr.Length; i++)
        {
            if (arrayedStr[i] != arrayedStr[arrayedStr.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}