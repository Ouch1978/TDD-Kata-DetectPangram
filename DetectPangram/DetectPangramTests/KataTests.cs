using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void IsPangramTest()
        {
            Assert.AreEqual( true , Kata.IsPangram( "The quick brown fox jumps over the lazy dog." ) );
        }

        [TestMethod()]
        public void IsPangramTest2()
        {
            Assert.AreEqual( true , Kata.IsPangram( "The quick brown fox jumps over the lazy dog 1." ) );
        }

        [TestMethod()]
        public void IsPangramTest3()
        {
            Assert.AreEqual( false , Kata.IsPangram( "The quick." ) );
        }
    }
}