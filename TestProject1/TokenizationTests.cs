using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassificationGUI.Business;

namespace Test
{
    [TestClass]
    public class TokenizationTests
    {
        [TestMethod]
        public void RemovePunctuation1()
        {
            string teststring = "store?";
            string actual = Tokenization.RemovePunctuation(teststring);
            string expected = "store";
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovePunctuation2()
        {
            string teststring = "store!";
            string actual = Tokenization.RemovePunctuation(teststring);
            string expected = "store";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovePunctuation3()
        {
            string teststring = "store's";
            string actual = Tokenization.RemovePunctuation(teststring);
            string expected = "stores";

            Assert.AreNotEqual(expected, actual);
        }
    }
}
