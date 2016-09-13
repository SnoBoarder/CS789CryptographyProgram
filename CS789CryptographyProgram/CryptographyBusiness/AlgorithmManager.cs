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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="n"></param>
		/// <param name="gcd"></param>
		/// <param name="x_0"></param>
		/// <param name="y_0"></param>
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

			/// Below we compile the information that we'll need to use for finding x_0 and y_0
			/// the following is an example of what we'll have a list of:
			/// 
			/// Given:
			///		m = 619
			///		n = 437
			/// 
			/// We'll have an array of:
			/// 
			///		1) 619 - 1 * 437 = 182
			///		2) 437 - 2 * 182 = 73
			///		3) 182 - 2 * 73  = 36
			///		4) 73  - 2 * 36  = 1
			///
			/// Using (1), the EuclideanIteration struct will have:
			///		largeNum = 619;
			///		smallNum = 437;
			///		remainder = 182;
			///		smallNumMultiplier = 1;
			/// 
			/// This is only useful if the last item in the array has a remainder of 1, 
			/// which states that "m" and "n" are relatively prime
			while (true)
			{
				euclideanIteration = new EuclideanIteration();
				euclideanIteration.largeNum = largeNum;
				euclideanIteration.smallNum = smallNum;
				euclideanIteration.remainder = largeNum % smallNum;
				euclideanIteration.smallNumMultiplier = (largeNum - euclideanIteration.remainder) / smallNum;

				euclideanIterations.Add(euclideanIteration);

				if (euclideanIteration.remainder == 0)
				{
					gcd = euclideanIteration.smallNum;
					break;
				}

				if (euclideanIteration.remainder == 1)
				{
					gcd = euclideanIteration.remainder;
					break;
				}

				largeNum = smallNum;
				smallNum = euclideanIteration.remainder;
			}

			/// traverse the remainders backwards to find the x_0 and y_0 values
			/// we'll start out with equation 4, substitute values with previous equations until we reach the end (1):
			///		1 * 73 - 2 * 36					// start with equation 4
			///		1 * 73 - 2 * (182 - 2 * 73)		// substitute "back" with equation 3
			///		1 * 73 - 2 * 182 + 4 * 73
			///		5 * 73 - 2 * 182				// end result of substituting equation 3
			///		5 * (437 - 2 * 182) - 2 * 182	// substitute "front" with equation 2
			///		5 * 437 - 10 * 182 - 2 * 182
			///		5 * 437 - 12 * 182				// end result of substituting equation 2
			///		5 * 437 - 12 * (619 - 1 * 437)	// substitute "back" with equation 1
			///		5 * 437 - 12 * 619 + 12 * 437
			///		17 * 437 - 12 * 619				// end result of substituting equation 1
			/// we've reached equation 1, end!
			///		x_0 = -12
			///		y_0 = 17
			int len = euclideanIterations.Count;

			euclideanIteration = euclideanIterations[len - 1];

			/// starting with equation 4: 1 * 73 - 2 * 36
			int multiplierA = 1; // 1
			int a = euclideanIteration.largeNum; // 73

			int multiplierB = euclideanIteration.smallNumMultiplier; // 2
			int b = euclideanIteration.smallNum; // 36

			--len;

			// always start evaluating the back first
			bool evaluateFront = false;

			// continue until we hit the last index
			while (len > 0)
			{
				euclideanIteration = euclideanIterations[len - 1];

				if (!evaluateFront)
				{
					// i.e. evaluating 1 * 73 - 2 * (182 - 2 * 73) = 5 * 73 - 2 * 182
					b = euclideanIteration.largeNum; // 182
					multiplierA += multiplierB * euclideanIteration.smallNumMultiplier; // 5
				}
				else
				{
					// i.e. evaluating 5 * (437 - 2 * 182) - 2 * 182 = 5 * 437 - 12 * 182
					a = euclideanIteration.largeNum; // 437
					multiplierB += multiplierA * euclideanIteration.smallNumMultiplier; // 12
				}

				// toggle between the front evaluation and back evaluation
				evaluateFront = !evaluateFront;
				--len;
			}

			// TODO: Make sure m and n are still valid in relation to x_0 and y_0
			x_0 = -multiplierB;
			y_0 = multiplierA;
		}
	}
}
