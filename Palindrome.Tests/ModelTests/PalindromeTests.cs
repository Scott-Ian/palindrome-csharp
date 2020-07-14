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
  }
}

// NameOfMethodTesting_DescriptionOfBehavior_ExpectedReturnValue()