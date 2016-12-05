using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CryptographyBusiness
{
	public static class AlgorithmManager
	{

		#region Fast Euclidean Algorithm

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

		#endregion

		#region Verbose Euclidean Algorithm

		private struct EuclideanIteration
		{
			public int largeNum;
			public int smallNum;
			public int smallNumMultiplier;
			public int remainder;
		}

		/// <summary>
		/// TODO: Make sure to contain with appropriately defined modulo!
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
				euclideanIteration.smallNumMultiplier = (largeNum - euclideanIteration.remainder) / smallNum; // TOOD: Figure out how to optimize this division

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

		#endregion

		#region Fast Exponentiation Algorithm

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="e"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		public static int FastExponentiationAlgorithm(int x, int e, int m)
		{
			// start out at 1 and build up whenever e is ever odd
			int answer = 1;

			while (e > 0)
			{
				if (e % 2 == 1)
				{
					// e is odd! subtract one from e and multiply current answer by the current x
					--e;
					answer = (answer * x) % m;
				}

				// square X mod M
				x = (x * x) % m;

				// we know that e is even at this point, so divide it. continue dividing it until e is 0
				e = e >> 1; // same as dividing by 2, but faster with bit shifting by 1
			}

			return answer;
		}

		#endregion

		#region Primitive Root Search Algorithm

		/// <summary>
		/// TODO: Confirm this works
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public static List<int> PrimitiveRootSearchAlgorithm(int val)
		{
            List<int> list = new List<int>();

			// traverse from 2 to val - 1
			for (int i = 2; i < val - 1; ++i)
			{
				int b = 1;
				bool flag = true;

				// traverse from 0 to half of provided val
				for (int j = 0; j < val / 2; ++j)
				{
					// current b * i mod provided val
					b = (b * i) % val;

					if (b % val == 1)
					{
						flag = false;
						break;
					}
				}

				if (flag)
				{
                    //return i;
                    list.Add(i);
                }
			}

			return list;
		}

		#endregion

        public static void Ugh()
        {
            int start = 2;
            int mod = 23;

            int current = start;
            double sqrt;

            while (true)
            {
                sqrt = Math.Sqrt(current);
                if (sqrt % 1 == 0)
                {
                    // whole number!
                    current += mod;
                    Console.WriteLine("Yes!: " + sqrt);
                }
                else
                {
                    current += mod;
                    Console.WriteLine("No!: " + current);
                }

                if (sqrt > mod)
                    break;
            }
        }

        public static void Ugh2()
        {
            int check = 60;
            int mod = 71;

            int num = 1;

            while (num < mod)
            {
                if ((num*num)%mod == check)
                {
                    Console.WriteLine("we found one: " + num);
                }

                num++;
            }
        }

		#region Baby Step Giant Step Algorithm

		/// <summary>
		/// TODO: FIX THIS
		/// b^l = a. finding l
		/// 
		/// log_b a % prime = l
		/// 
		/// l = im + j
		/// </summary>
		/// <param name="a">generator to the power of l</param>
		/// <param name="b">generator</param>
		/// <param name="prime">prime</param>
		/// <returns>l</returns>
		public static int BabyStepGiantStepAlgorithm(int a, int b, int prime)
		{
			// b^(im+j)

			// m = ceil(root(n))
			// i >= 0
			// i < m
			// j >= 0
			// j < m

			Hashtable table = new Hashtable();

			// get the ceiling square root of the provided prime
			int m = Convert.ToInt32(Math.Ceiling(Math.Sqrt(prime)));

			// traverse all options of power of j and store the pair
			for (int j = 0; j < m; ++j)
			{
				table[j] = Math.Pow(b, j) % prime;
				Debug.WriteLine(j + "|" + table[j]);
			}

			// keep track of b^(-1 * m) % prime
			double cachedBPowNegM = Math.Pow(b, -m) % prime;

			double tempA = a;
			// traverse every possible i
			for (int i = 0; i <= m; ++i)
			{
				// traverse every possible j
				for (int j = 0; j < m; ++j)
				{
					// if we find a match for a given i and j, then return i *m + j
					if ((tempA * Math.Pow(cachedBPowNegM, i)) % prime == (double)table[j])
					{
						Debug.WriteLine(i + "*" + m + "+" + j);
						return i * m + j;
					}
				}

				// 
				tempA = tempA * cachedBPowNegM;
			}

			return -1;
		}

		#endregion
	}
}
