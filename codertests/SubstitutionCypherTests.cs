using Coder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Coder.Tests
{
    [TestClass()]
    public class SubstitutionCypherTests
    {
        ResettableSet<char> alphabet;
        public SubstitutionCypherTests()
        {
            alphabet = new ResettableSet<char>();
            for (int i = 97; i <= 122; ++i)
            {
                alphabet.Add((char)i);
            }
        }

        [TestMethod()]
        public void encodeTest()
        {
            SubstitutionCypher sc = new SubstitutionCypher("hello", alphabet);

            Assert.AreEqual('a', alphabet[0]);
            Assert.AreEqual('z', alphabet[25]);

            SpecialVariableBaseNumber seed = new SpecialVariableBaseNumber(26);
            Assert.AreEqual("hello", sc.Encode(seed));

            seed = new SpecialVariableBaseNumber(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 });
            Assert.AreEqual("hfllo", sc.Encode(seed));

            seed = new SpecialVariableBaseNumber(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0 });
            Assert.AreEqual("hgllo", sc.Encode(seed));
        }

        [TestMethod()]
        public void DecodeTest()
        {
            SubstitutionCypher sc = new SubstitutionCypher("hgllo", alphabet);
            SpecialVariableBaseNumber seed = new SpecialVariableBaseNumber(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0 });
            Assert.AreEqual("hello", sc.Decode(seed));
        }

        [TestMethod()]
        public void EncodeDecodePairs()
        {
            SpecialVariableBaseNumber seed = new SpecialVariableBaseNumber(26);

            seed.Inc();
            for (int i = 0; i < 100000; ++i)
            {
                string originalString = "abcdefghijklmnopqrstuvwxyz";
                SubstitutionCypher original = new SubstitutionCypher(originalString, alphabet);
                if (i == 0)
                    Console.WriteLine($"{original.NumSeeds} possible combinations");
                string codedString = original.Encode(seed);
                Assert.AreNotEqual(originalString, codedString);
                SubstitutionCypher coded = new SubstitutionCypher(codedString, alphabet);
                Assert.AreEqual(originalString, coded.Decode(seed));
                seed.IncBy(732);
            }

            SubstitutionCypher usesLargeSeed = new SubstitutionCypher("hello", alphabet);
            seed = new SpecialVariableBaseNumber(26);
            seed.IncBy(usesLargeSeed.NumSeeds - 1);

            string borderEncoded = usesLargeSeed.Encode(seed);

            Console.WriteLine($"Using seed {seed}");

            Console.WriteLine($"Coded: {borderEncoded}");


            SubstitutionCypher reverseWithLargeSeed = new SubstitutionCypher(borderEncoded, alphabet);
            string decoded = reverseWithLargeSeed.Decode(seed);
            Console.WriteLine($"Decoded: {decoded}");

            Assert.AreEqual("hello", decoded);
            
        }
    }
}