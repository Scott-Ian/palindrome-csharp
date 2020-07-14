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
        PalindromeChecker testPalindromeChecker = new PalindromeChecker("HELLO");
        Assert.AreEqual("HELLO", testPalindromeChecker.Input);
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
        PalindromeChecker testPalindromeChecker = new PalindromeChecker("hannah");
        Assert.AreEqual(true, testPalindromeChecker.IsPalindrome());
      }  
    
    [TestMethod]
    public void IsPalindrome_ChecksIfMixedCaseStringIsPalidrome_True()
      {
        PalindromeChecker testPalindromeChecker = new PalindromeChecker("HanNah");
        Assert.AreEqual(true, testPalindromeChecker.IsPalindrome());
      }    
    }
  }

// NameOfMethodTesting_DescriptionOfBehavior_ExpectedReturnValue()