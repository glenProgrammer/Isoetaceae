using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Coder
{
    public class SubstitutionCypher : ICodeMethod
    {
        private string original;
        private ResettableSet<char> alphabetFrom, alphabetTo;

        private enum DIRECTION
        {
            ENCODE, DECODE
        }

        public SubstitutionCypher(string original, ResettableSet<char> alphabet)
        {
            this.original = original;
            this.alphabetFrom = alphabet;
            alphabetTo = new ResettableSet<char>(alphabetFrom);
        }

        public override string Decode(SpecialVariableBaseNumber seed)
        {
            return EncodeOrDecode(seed, DIRECTION.DECODE);
        }

        private string EncodeOrDecode(SpecialVariableBaseNumber seed, DIRECTION dir)
        {
            //FIXME This if statement is part of a temporary spike solution.
            if (seed.NumDigits < alphabetFrom.TotalInOriginal)
                seed.ExpandTo(alphabetFrom.TotalInOriginal);

            Debug.Assert(seed.NumDigits == alphabetFrom.TotalInOriginal);
            Debug.Assert(seed.NumDigits == alphabetTo.TotalInOriginal);
            Debug.Assert(seed.ToBigInt() < NumSeeds);

            Dictionary<char, char> alphabetMap = new Dictionary<char, char>();
            alphabetFrom.Reset();
            alphabetTo.Reset();

            for (int i = 0; i < alphabetFrom.TotalInOriginal; ++i)
            {
                char key = alphabetFrom[0];
                char value = alphabetTo[seed[i]];
                alphabetMap.Add(key, value);
                alphabetFrom.Remove(key);
                alphabetTo.Remove(value);
            }

            //TODO Look into a more effecient way of doing this, by constructing the desired map directly
            if (dir == DIRECTION.DECODE)
                alphabetMap = alphabetMap.ToDictionary(kp => kp.Value, kp => kp.Key);

            StringBuilder sb = new StringBuilder();
            foreach (char c in original)
            {
                if (c == '\n')
                    sb.Append(c);
                else
                    sb.Append(alphabetMap[c]);
            }

            return sb.ToString();
        }


        public override string Encode(SpecialVariableBaseNumber seed)
        {
            return EncodeOrDecode(seed, DIRECTION.ENCODE);
        }

        public override BigInteger NumSeeds => MathUtility.Fact(alphabetFrom.TotalInOriginal);
    }
}

            
        