using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReplaceWords;
using System;
using System.Collections.Generic;

namespace ReplaceWords.Tests
{
  [TestClass]
  public class ReplaceWordsTest
  {
    [TestMethod]
    public void SetProperty_StoresWords_True()
    {
      ReplaceWords testSentence = new ReplaceWords("this is a test sentence.");
      Assert.AreEqual(typeof(ReplaceWords), testSentence.GetType());
    }
    //
    // [TestMethod]
    // public void MakeArray_StringReturnsLetterArray_True()
    // {
    //   char[] testArray = {'w', 'o', 'r', 'd'};
    //   Words testWords = new Words("word");
    //   CollectionAssert.AreEqual(testArray, testWords.MakeArray());
    // }
    //
    // [TestMethod]
    // public void WordValue_FindLetterValue_Int()
    // {
    //   Words testWords = new Words("word");
    //   int value = testWords.GetValues("w");
    //   Assert.AreEqual(4, value);
    // }

  }
}
