using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Coder
{
    /// <summary>
    /// The least significant digit is base 1, the second least significant is base 2,
    /// the third least significant is base 3, etc.
    /// </summary>
    public class SpecialVariableBaseNumber
    {
        //stores digits little-endian.  (Least-significant digit is at index 0.)
        private List<int> numbers = new List<int>();

        public int NumDigits { get { return numbers.Count; } }

        public SpecialVariableBaseNumber()
        {
            numbers.Add(0);
        }

        /// <summary>
        /// Uses the list of numbers as the digits of the number.
        /// </summary>
        /// <param name="numbers">List of digits, with the least significant digit at index 0,
        /// and the most significant digit at index numbers.Count-1</param>
        public SpecialVariableBaseNumber(List<int> numbers)
        {
            for(int i = 0; i < numbers.Count; ++i)
            {
                Debug.Assert(numbers[i] < i + 1);
                Debug.Assert(numbers[i] >= 0);
            }
            this.numbers = numbers;
        }

        public void ExpandTo(int fillDigits)
        {
            while (numbers.Count < fillDigits)
                numbers.Add(0);
        }

        public SpecialVariableBaseNumber(BigInteger num)
        {
            numbers.Add(0);
            if(num > 0)
                IncBy(num);
        }

        public BigInteger ToBigInt()
        {
            BigInteger num = 0;
            for(int i = numbers.Count-1; i > 0; --i)
            {
                //current base is i-1
                num += numbers[i] * MathUtility.Fact(i);
            }
            return num;
        }

        /// <summary>
        /// Creates a number with numDigits digits, each initialized to 0
        /// </summary>
        /// <param name="numDigits">Must be positive number</param>
        public SpecialVariableBaseNumber(int numDigits)
        {
            Debug.Assert(numDigits > 0);

            numbers = new List<int>();
            for (int i = 0; i < numDigits; ++i)
                numbers.Add(0);
        }

        /// <summary>
        /// Increments in place
        /// </summary>
        /// <param name="inc">Must be a positive number</param>
        public void IncBy(BigInteger inc)
        {
            Debug.Assert(inc > 0);

            //In the special case where the number is currently 0, create room in the list
            if (numbers.Count == 1)
                numbers.Add(0);

            int cBase = 2;
            int innerBase = cBase;
            int idxOutter = cBase - 1;
            int idxInner = idxOutter;
            BigInteger addThisTime = (inc / MathUtility.Fact(cBase-1)) % innerBase;

            while (inc > 0)
            {

                //overflow case
                while (numbers[idxInner] + addThisTime >= innerBase)
                {
                    numbers[idxInner] = (int) ((numbers[idxInner] + addThisTime) % innerBase);
                    if(idxInner == idxOutter) //we are only really adding a portion of inc in this case
                        inc -= addThisTime * MathUtility.Fact(innerBase - 1);
                    ++idxInner;
                    ++innerBase;
                    if (idxInner >= numbers.Count)
                        numbers.Add(0);
                    addThisTime = 1; //we need to add the overflow portion to the next digit
                }

                //no overflow case (happens with or without overflow case, but always happens)
                //TODO fix redundancies
                numbers[idxInner] = (int) ((numbers[idxInner] + addThisTime) % innerBase);
                if (idxInner == idxOutter) //we are only really adding a portion of inc in this case
                    inc -= addThisTime * MathUtility.Fact(innerBase - 1);
                if (inc > 0 && idxInner == numbers.Count-1) //no overflow on this operation, but we need to add to a more significant digit
                    numbers.Add(0);

                ++cBase;
                innerBase = cBase;
                ++idxOutter;
                idxInner = idxOutter;
                addThisTime = (inc / MathUtility.Fact(cBase - 1)) % cBase;
            }
        }

        public void Inc()
        {
            IncBy(1);
        }

        /// <summary>
        /// When working with these numbers, it is nice to have big-endian numbers, which means
        /// the most significant digit is in index 0.
        /// </summary>
        /// <returns>Value of digit</returns>
        public int this[int index]
        {
            get
            {
                return numbers[numbers.Count-1-index];
            }
        }
        
        public override string ToString()
        {
            string ret = "";
            for (int i = numbers.Count-1; i >= 0; --i)
            {
                ret += numbers[i].ToString();
                if (i != 0)//if it's not the last time
                    ret += ",";
            }
            return ret;
        }
    }
}
