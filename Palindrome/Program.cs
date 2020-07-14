using System;
using Palindrome;

namespace Palindrome
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a word to see if it is a palindrome:");
      PalindromeChecker newPalindrome = new PalindromeChecker(Console.ReadLine());

      if (newPalindrome.IsPalindrome())
      {
        Console.WriteLine("It is a palindrome!");
      }
      else
      {
        Console.WriteLine("It is not a palindrome!");
      }
      Main();
    }
  }
}