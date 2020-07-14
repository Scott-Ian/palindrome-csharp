using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeCheckerTests
  {
    [TestMethod]
  public void PalindromeCheckerConstructor_ConstructsInstanceOfClass_Hello()
      {
        PalindromeChecker testPalindromeChecker = new PalindromeChecker("Hello");
        Assert.AreEqual("Hello", testPalindromeChecker.Input);
      } 

    [TestMethod]
    public void IsPalindrome_ChecksIfStringIsPalindrome_False()
      {
        PalindromeChecker testPalindromeChecker = new PalindromeChecker("Grapefruit");
        Assert.AreEqual(false, testPalindromeChecker.IsPalindrome());
      } 

    [TestMethod]
    public void IsPalindrome_ChecksIfStringIsPalidrome_True()
      {
        PalindromeChecker testPalindromeChecker = new PalindromeChecker("Hannah");
        Assert.AreEqual(true, testPalindromeChecker.IsPalindrome());
      }  
    }
  }

// NameOfMethodTesting_DescriptionOfBehavior_ExpectedReturnValue()