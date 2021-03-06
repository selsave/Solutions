using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiverseSpace.Tests
{
    [TestClass()]
    public class SoultionTests
    {
        [TestMethod]
        public void solution_AllZero_ArgumentException()
        {
            //Arrange
            var obj = new Soultion();

            //Act &Assert
            Assert.ThrowsException<ArgumentException>(() => obj.solution(0, 0, 0));
        }
        [TestMethod]
        public void solution_Above100A_ArgumentOutOfRangeException()
        {
            //Arrange
            var obj = new Soultion();

            //Act &Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => obj.solution(101, 10, 3));

        }

        [TestMethod]
        public void solution_Below0_ArgumentOutOfRangeException()
        {
            //Arrange
            var obj = new Soultion();

            //Act &Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => obj.solution(-10, 10, 3));

        }
        [TestMethod()]
        public void solution_Example1A6B1C1_aabaacaa()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(6, 1, 1);

            //Assert
            Assert.AreEqual(result.ToString(), "aabaacaa");
        }
        [TestMethod]
        public void solution_Example2A1B3C1_bbabc()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(1, 3, 1);

            //Assert
            Assert.AreEqual(result.ToString(), "bbabc");
        }
        [TestMethod]
        public void solution_Example3A0B1C8_ccbcc()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(0, 1, 8);

            //Assert
            Assert.AreEqual(result.ToString(), "ccbcc");
        }
        [TestMethod]
        public void solution_AllSuperSmallA1B1C1_abc()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(1, 1, 1);

            //Assert
            Assert.AreEqual(result.ToString(), "abc");
        }
        [TestMethod]
        public void solution_TwoZerosA0B0C3_cc()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(0, 0, 3);

            //Assert
            Assert.AreEqual(result.ToString(), "cc");
        }
        [TestMethod]
        public void solution_TwoZerosA3B0C0_aa()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(3, 0, 0);

            //Assert
            Assert.AreEqual(result.ToString(), "aa");
        }
        [TestMethod]
        public void solution_TwoZerosA0B3C0_bb()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(0, 3, 0);

            //Assert
            Assert.AreEqual(result.ToString(), "bb");
        }
        
        [TestMethod]
        public void solution_AllSimilarA4B4C4_abcabcabcabc()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(4, 4, 4);

            //Assert
            Assert.AreEqual(result.ToString(), "abcabcabcabc");
        }

        [TestMethod]
        public void solution_OneBigA10B2C2_aabaacaabaacaa()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(10, 2, 2);

            //Assert
            Assert.AreEqual(result.ToString(), "aabaacaabaacaa");
        }
        [TestMethod]
        public void solution_OneBigA2B12C2_bbabbcbbabbcbb()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(2, 12, 2);

            //Assert
            Assert.AreEqual(result.ToString(), "bbabbcbbabbcbb");
        }
        [TestMethod]
        public void solution_OneBigA2B2C10_ccaccbccaccbcc()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(2, 2, 10);

            //Assert
            Assert.AreEqual(result.ToString(), "ccaccbccaccbcc");
        }
        [TestMethod]
        public void solution_TwoBigA25B20C0_aabaabaabaabaabababababababababababababababab()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(25, 20, 0);

            //Assert
            Assert.AreEqual(result.ToString(), "aabaabaabaabaabababababababababababababababab");
        }

        [TestMethod]
        public void solution_MaxA55B65C75_ccbccbccbccbccbccbccbccbccbcbcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabc()
        {
            //Arrange
            var obj = new Soultion();

            //Act
            var result = obj.solution(55, 65, 75);

            //Assert
            Assert.AreEqual(result.ToString(), "ccbccbccbccbccbccbccbccbccbcbcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabc");
        }
    }
}