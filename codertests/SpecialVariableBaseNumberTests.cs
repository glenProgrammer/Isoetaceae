using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Coder.Tests
{
    [TestClass()]
    public class SpecialVariableBaseNumberTests
    {
        [TestMethod()]
        public void SpecialVariableBaseNumberTest()
        {
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber();
            Assert.AreEqual("0", num.ToString());
        }

        [TestMethod()]
        public void SpecialVariableBaseNumberTest1()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 10; ++i)
            {
                numbers.Add((int)i);
            }
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber(numbers);

            Assert.AreEqual("10,9,8,7,6,5,4,3,2,1,0", num.ToString());
        }

        [TestMethod()]
        public void SpecialVariableBaseNumberTest2()
        {
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber(3);
            Assert.AreEqual("0,0,0", num.ToString());
        }

        [TestMethod()]
        public void SpecialVariableBaseNumberTest3()
        {
            BigInteger bigNum = BigInteger.Parse("536");
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber(bigNum);
            Assert.AreEqual(bigNum, num.ToBigInt());
        }

        [TestMethod()]
        public void IncByTest()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 2; ++i)
            {
                numbers.Add(i);
            }
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber(numbers);

            Assert.AreEqual("2,1,0", num.ToString());

            num.IncBy(2);
            Assert.AreEqual("1,0,1,0", num.ToString());

            num.IncBy(1);
            Assert.AreEqual("1,1,0,0", num.ToString());

            num.IncBy(1);
            Assert.AreEqual("1,1,1,0", num.ToString());

            num.IncBy(1);
            Assert.AreEqual("1,2,0,0", num.ToString());

            num.IncBy(1);
            Assert.AreEqual("1,2,1,0", num.ToString());

            num.IncBy(1);
            Assert.AreEqual("2,0,0,0", num.ToString());

            num.IncBy(6);
            Assert.AreEqual("3,0,0,0", num.ToString());

            num.IncBy(6);
            Assert.AreEqual("1,0,0,0,0", num.ToString());

        }

        [TestMethod()]
        public void IncTest()
        {
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber();
            Assert.AreEqual("0", num.ToString());

            for (int i = 0; i < 12; ++i)
                num.Inc();
            Assert.AreEqual("2,0,0,0", num.ToString());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 10; ++i)
            {
                numbers.Add((int)i);
            }
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber(numbers);

            Assert.AreEqual("10,9,8,7,6,5,4,3,2,1,0", num.ToString());
        }

        [TestMethod()]
        public void Indexer()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 10; ++i)
            {
                numbers.Add((int)i);
            }
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber(numbers);

            Assert.AreEqual(10, num[0]);
            Assert.AreEqual(8, num[2]);
            Assert.AreEqual(0, num[10]);
        }

        [TestMethod()]
        public void ToBigIntTest()
        {
            SpecialVariableBaseNumber num = new SpecialVariableBaseNumber();
            Assert.AreEqual(0, (int)num.ToBigInt());

            for (int i = 1; i < 100; ++i)
            {
                num.Inc();
                Assert.AreEqual(i, (int)num.ToBigInt());
            }

            num = new SpecialVariableBaseNumber();
            Assert.AreEqual(0, (int)num.ToBigInt());
            for (int i = 1; i < 1000; ++i)
            {
                num.IncBy(17);
                Assert.AreEqual(17 * i, (int)num.ToBigInt());
            }
        }

    }
}