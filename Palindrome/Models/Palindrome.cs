using System;

namespace Palindrome 
{
  public class PalindromeChecker
  {
    public string Input {get; set;}

    public PalindromeChecker(string input)
    {
      Input = input;
    }
    
    public bool IsPalindrome()
    {
      for (int i = 0; i < (Input.Length / 2); i++)
      {
        if (Input[i] != Input[Input.Length - (1 + i)])
        {
          return false;
        }
      }
      return true;
    }
  }
}