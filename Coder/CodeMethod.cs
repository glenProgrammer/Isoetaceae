using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Coder
{
    public abstract class ICodeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="seed">The base of this number should be the same as the number
        /// of variables in the alphabet that is being worked with, including numbers</param>
        /// <returns></returns>
        public abstract string Encode(SpecialVariableBaseNumber seed);

        public abstract string Decode(SpecialVariableBaseNumber seed);
        public abstract BigInteger NumSeeds { get; }

        private SpecialVariableBaseNumber stringToSpecialNum(String key)
        {
            //FIXME change range to always be valid, and well-spaced
            const int MAX_VAL = 126;
            const int MIN_VAL = 32;

            const int RANGE = MAX_VAL - MIN_VAL;

            //GET A UNIQUE HASH
            BigInteger hash = 0;
            for (int i = 0; i < key.Length; ++i)
                hash += ((int)key[i] - MIN_VAL) * (BigInteger) Math.Pow(RANGE, i);

            //DISTRIBUTE ACROSS BROADER RANGE
            hash = hash * (NumSeeds / (BigInteger) Math.Pow(RANGE, key.Length));

            return new SpecialVariableBaseNumber(hash);
        }

        public string Encode(String key)
        {
            SpecialVariableBaseNumber specialNum = stringToSpecialNum(key);
            return Encode(specialNum);
        }

        public string Decode(String key)
        {
            SpecialVariableBaseNumber specialNum = stringToSpecialNum(key);
            return Decode(specialNum);
        }
    }
}