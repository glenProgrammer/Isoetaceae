using System.Diagnostics;
using System.Numerics;

namespace Coder
{
    public static class MathUtility
    {
        /// <summary>
        /// Factorial
        /// </summary>
        public static BigInteger Fact(int num)
        {
            Debug.Assert(num >= 0);

            if (num >= 0 && num <= 1)
                return 1;

            if (num == 2)
                return 2;
            else
                return num * Fact(num - 1);
        }
    }
}
