using System.Collections.Generic;

namespace CryptographyBusiness
{
	public static class AlgorithmManager
	{
		/// <summary>
		/// Get the greatest common divisor using Euclidean's Algorithm
		/// </summary>
		/// <param name="x">first value</param>
		/// <param name="y">second value</param>
		/// <returns>Greatest Common Divisor</returns>
		public static int FastEuclideanAlgorithm(int x, int y)
		{
			// this is the fastest way without having to track anything.
			int largeNum;
			int smallNum;

			// make sure we setup the correct larger value
			if (x >= y)
			{
				largeNum = x;
				smallNum = y;
			}
			else
			{
				largeNum = y;
				smallNum = x;
			}

			int remainder;

			// go through the loop until we reach relatively prime (1) or 0
			while (true)
			{
				remainder = largeNum % smallNum;

				if (remainder == 0)
				{
					// we've found a match :O! return the previous remainder
					return smallNum;
				}

				if (remainder == 1)
					return remainder;

				// we haven't found a match,
				// continue with shifting the smallNum to largeNum and remainder to smallNum
				largeNum = smallNum;
				smallNum = remainder;
			}
		}

		public struct EuclideanIteration
		{
			public int largeNum;
			public int smallNum;
			public int smallNumMultiplier;
			public int remainder;
		}

		public static void VerboseEuclideanAlgorithm(int m, int n, out int gcd, out int x_0, out int y_0)
		{
			gcd = FastEuclideanAlgorithm(m, n);
			x_0 = 0;
			y_0 = 0;

			if (gcd == 0)
				return;

			// this is the fastest way without having to track anything.
			int largeNum;
			int smallNum;

			// make sure we setup the correct larger value
			if (m >= n)
			{
				largeNum = m;
				smallNum = n;
			}
			else
			{
				largeNum = n;
				smallNum = m;
			}

			// leverage gcd(m, n) = gcd(n, m % n) and get all values until gcd = 1
			List<EuclideanIteration> euclideanIterations = new List<EuclideanIteration>();

			EuclideanIteration euclideanIteration = new EuclideanIteration();
			
			while (true)
			{
				euclideanIteration = new EuclideanIteration();
				euclideanIteration.largeNum = largeNum;
				euclideanIteration.smallNum = smallNum;
				euclideanIteration.remainder = largeNum % smallNum;
				euclideanIteration.smallNumMultiplier = (largeNum - euclideanIteration.remainder) / smallNum;

				euclideanIterations.Add(euclideanIteration);

				if (euclideanIteration.remainder == 0)
					break;

				if (euclideanIteration.remainder == 1)
					break;

				largeNum = smallNum;
				smallNum = euclideanIteration.remainder;
			}

			// traverse the remainders backwards to find the x_0 and y_0 values
			int len = euclideanIterations.Count;

			euclideanIteration = euclideanIterations[len - 1];

			int multiplierA = 1;
			int a = euclideanIteration.largeNum;

			int multiplierB = euclideanIteration.smallNumMultiplier;
			int b = euclideanIteration.smallNum;

			len--;

			int multiplierC;
			int c;

			while (len > 0)
			{
				euclideanIteration = euclideanIterations[len - 1];

				if (b != euclideanIteration.largeNum - euclideanIteration.smallNumMultiplier * euclideanIteration.smallNum)
					throw new System.Exception("value b not matching higher level remainder");

				if (a != euclideanIteration.smallNum)
					throw new System.Exception("value a not matching value smallNum");

				b = euclideanIteration.largeNum;

				multiplierA += multiplierB * euclideanIteration.smallNumMultiplier;

				len--;

				//////////////////////////////

				if (len - 1 <= 0)
					break;

				euclideanIteration = euclideanIterations[len - 1];

				if (a != euclideanIteration.largeNum - euclideanIteration.smallNumMultiplier * euclideanIteration.smallNum)
					throw new System.Exception("value a not matching higher level remainder");

				if (b != euclideanIteration.smallNum)
					throw new System.Exception("value b not matching value smallNum");

				a = euclideanIteration.largeNum;

				multiplierB += multiplierA * euclideanIteration.smallNumMultiplier;

				len--;
			}

			// TODO: Make sure m and n are still valid in relation to x_0 and y_0
			x_0 = -multiplierB;
			y_0 = multiplierA;
		}
	}
}
