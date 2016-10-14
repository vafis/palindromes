using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ConsoleApplication1;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;


namespace UnitTests
{
   // [TestClass]
    public class UnitTest1
    {
     //   [TestMethod]
        public void TestMethod1()
        {
        }

        [Fact]
        public void Create_PairWise()
        {
            var pal=new Palindrome();
            string text = "abcdzzefg";
            var matches = Regex.Split(text, @"(\w)\1+?");
            var ret = pal.GetPairWise(matches);
            Assert.NotNull(ret);
            Assert.Equal("abcdz", ret.First());
            Assert.Equal("zefg", ret.Last());
        }

        [Fact]
        public void Create_Formatted()
        {
            var pal = new Palindrome();
            var pair = new List<string> {"adcdx", "xdcba"};
            var ret = pal.Format(pair);
            Assert.NotNull(ret);
            Assert.Equal(ret.First().Key, "xdcda");
        }

        [Fact]
        public void Get_Palindromes()
        {
            var pal = new Palindrome();
            var ret = pal.GetPalindromes("asdwwdswerdewrrwedrgrgrere");
            Assert.Equal("sdwwds",ret.First());
            Assert.Equal("rdewrrwedr", ret.Last());
        }
    }
}
