using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

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
		public static BigInteger FastExponentiationAlgorithm(BigInteger x, BigInteger e, BigInteger m)
		{
			// start out at 1 and build up whenever e is ever odd
			BigInteger answer = 1;

			while (e > 0)
			{
				if (e % 2 == 1)
				{
					// e is odd! subtract one from e and multiply current answer by the current x
					--e;
					answer = BigInteger.Multiply(answer, x) % m;
				}

				// square X mod M
				x = (x * x) % m;

				// we know that e is even at this point, so divide it. continue dividing it until e is 0
				e = e >> 1; // same as dividing by 2, but faster with bit shifting by 1
			}

			return answer;
		}

		#endregion

		#region Mod Inverse

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		public static BigInteger ModInverse(int a, int n)
		{
			return FastExponentiationAlgorithm(a, n - 2, n);
		}

		#endregion

		#region Primitive Root Search Algorithm

		/// <summary>
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public static List<int> PrimitiveRootSearchAlgorithm(int val, int count = 1)
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

					if (count != -1 && list.Count == count)
						return list;
				}
			}

			return list;
		}

		#endregion

		#region Baby Step Giant Step Algorithm

		/// <summary>
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

			// m = floor(root(n))
			// i >= 0
			// i <= m
			// j >= 0
			// j < m

			Hashtable table = new Hashtable();

			// get the floor square root of the provided prime
			int m = Convert.ToInt32(Math.Floor(Math.Sqrt(prime)));

			// traverse all options of power of j and store the pair
			for (int j = 0; j < m; ++j)
			{
				table[j] = FastExponentiationAlgorithm(b, j, prime);
				Debug.WriteLine(j + "|" + table[j]);
			}

			// cache b^(-1 * m) % prime
			BigInteger cachedBPowNegM = FastExponentiationAlgorithm(ModInverse(b, prime), m, prime);

			// cache every iteration of (a * cachedBPowNegM) % prime
			BigInteger aBig = new BigInteger(a);
			BigInteger primeBig = new BigInteger(prime);
			BigInteger cachedPowI;
			// traverse every possible i
			for (int i = 0; i <= m; ++i)
			{
				cachedPowI = (FastExponentiationAlgorithm(cachedBPowNegM, i, prime) * aBig) % primeBig;

				// traverse every possible j
				for (int j = 0; j < table.Count; ++j)
				{
					// if we find a match for a given i and j, then return i * m + j
					if (cachedPowI == (BigInteger)table[j])
					{
						Console.WriteLine(i + "*" + m + "+" + j);
						return i * m + j;
					}
				}
			}

			return -1;
		}

		#endregion

		#region Miller-Rabin Test Optimal

		/// <summary>
		/// http://mjs5.com/2016/02/23/c-miller-rabin-primality-test-class/
		/// </summary>
		/// <param name="candidate"></param>
		/// <param name="confidence"></param>
		/// <returns></returns>
		public static bool MillerRabinOptimal(long candidate, int confidence = 3)
		{
			switch (candidate)
			{
				case 1:
					return false;
				case 2:
				case 3:
					return true;
			}

			var r = 0;
			var d = candidate - 1;

			// divide "d" until it's not even
			while (d % 2 == 0)
			{
				r++;

				// dividing by 2
				d >>= 1;
			}

			if (r == 0)
			{
				// we had no divisions. it's even
				return false; //composite
			}

			Random rnd = new Random();

			for (var k = 0; k < confidence; ++k)
			{
				long a = LongRandom(2, candidate - 1) | 1;
				long x = (long)FastExponentiationAlgorithm(a, d, candidate);

				if (x == 1)
				{
					// passed
					return true;
				}

				for (var attempt = 0; attempt < r; attempt++)
				{
					if (x == candidate - 1)
					{
						// passed
						return true;
					}

					x = (long)FastExponentiationAlgorithm(x, 2, candidate);
				}

				if (x == candidate - 1)
				{
					return true;
				}
			}

			return false;
		}
		#endregion

		#region Miller-Rabin Test Meh

		public static bool MillerRabinTest(long n, int totalChecks = 3)
		{
			if (n < 2)
				return false; // too small

			if (n % 2 == 0)
				return false; // it's even -_-

			int r = 0;
			double dividingN = n - 1;
			while (true)
			{
				dividingN = dividingN / 2.0;

				Console.WriteLine(dividingN);

				if (dividingN != Math.Floor(dividingN))
					break; // it didn't divide nicely. we're done

				r++;
			}

			Console.WriteLine("r = " + r);

			var m = (n - 1) / ((int)Math.Pow(2, r));

			Console.WriteLine("m = " + m);

			Random rnd = new Random();

			//for (int check = 0; check < totalChecks; ++check)
			//{
			//    int b = rnd.Next(2, (int)n - 1);

			//    // make sure b is relatively prime to n
			//    while (FastEuclideanAlgorithm((int)n, b) == 0)
			//    {
			//        b = rnd.Next(2, (int)n - 1);
			//    }

			//    Int64 test = FastExponentiationAlgorithm(b, m, n);

			//    if (test == 1 || test == n - 1)
			//    {
			//        // passed the test, go to the next number
			//        continue;
			//    }
			//    else
			//    {
			//        bool success = false;

			//        for (int attempt = 1; attempt < r; ++attempt)
			//        {
			//            test = (test * test) % n;

			//            if (test == 1)
			//            {
			//                break;
			//            }
			//            else if (test == n - 1)
			//            {
			//                success = true;
			//                break;
			//            }
			//        }

			//        if (success)
			//        {
			//            // passed the test, go to the next number
			//            continue;
			//        }

			//        // failed
			//        return false;
			//    }
			//}

			for (int check = 0; check < totalChecks; ++check)
			{
				var b = (long)rnd.Next(2, (int)n - 1);

				while (FastEuclideanAlgorithm((int)n, (int)b) == 0)
				{
					b = rnd.Next(2, (int)n - 1);
				}

				BigInteger test = FastExponentiationAlgorithm(b, m, n);

				if (test == 1)
				{
					// passed the test, go to the next number
					continue;
				}
				else if (test == n - 1)
				{
					// passed the test, go to the next number
					continue;
				}
				else
				{
					// check against the other values
					for (int attempt = 1; attempt < r; ++attempt)
					{
						test = FastExponentiationAlgorithm(b, m * 2 * attempt, n);

						if (test == n - 1)
						{
							// passed the test, go to the next number
							continue;
						}
					}

					// it's composite
					return false;
				}
			}

			return true;
		}

		#endregion

		#region Random long Number

		private static RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();
		private static byte[] _uint32Buffer = new byte[4];

		private static long LongRandom(long minValue, long maxValue)
		{
			if (minValue > maxValue)
				throw new ArgumentOutOfRangeException("minValue");
			if (minValue == maxValue) return minValue;
			Int64 diff = maxValue - minValue;
			while (true)
			{
				_rng.GetBytes(_uint32Buffer);
				UInt32 rand = BitConverter.ToUInt32(_uint32Buffer, 0);

				Int64 max = (1 + (Int64)UInt32.MaxValue);
				Int64 remainder = max % diff;
				if (rand < max - remainder)
				{
					return (Int64)(minValue + (rand % diff));
				}
			}
		}

		#endregion

		#region Random Prime Basic

		public static int GetRandomPrimeBasic(int range)
		{
			var val = (Int32)1;

			while (!MillerRabinOptimal(val))
				val = (int)LongRandom(2, range);

			return val;
		}

		#endregion

		#region Blum-Blum-Shub Random Number Generator

		public static int BlumBlumShubRandomNumberGenerator(int bitCount = 32)
		{
			if (bitCount > 32)
				bitCount = 32; // cannot have an int32 greater than 32 bits. set it to 32

			var p = GetRandomPrimeBasic(Int16.MaxValue);
			var q = GetRandomPrimeBasic(Int16.MaxValue);

			var n = p * q;

			string bits = "";

			// set seed_0
			long seed = LongRandom(1, n);
			bits = ((int)(seed % 2)).ToString();
			for (int i = 1; i < bitCount; ++i) // cannot use "n" bits cuz... that's way too freaking big
			{
				seed = (seed * seed) % n; // using s_0 to then get s_1
				bits += ((int)(seed % 2)).ToString(); // mod s_1
			}

			return Convert.ToInt32(bits, 2);
		}

		#endregion

		#region Random Prime Blum-Blum-Shub

		public static int RandomPrimeBlumBlumShub(int bitCount)
		{
			int prime = 4;

			while (!MillerRabinOptimal(prime))
				prime = BlumBlumShubRandomNumberGenerator(bitCount);

			return prime;
		}

		#endregion

		#region Pollard's Rho Method

		public static int PollardsRhoMethod(int n, int xDefault = 2)
		{
			int x = xDefault;
			int y = x * x + 1; // unrolled version of x^2 + 1

			int g;
			while (true)
			{
				g = FastEuclideanAlgorithm(x - y, n);

				if ((g > 1 && g < n) || g == 0)
				{
					// we found a divisor
					return g;
				}
				else if (g >= n)
				{
					// we failed. recursively try again with a different x default
					return PollardsRhoMethod(n, xDefault + 1);
				}

				// g equals 1

				x = (x * x + 1) % n; // unrolled version of (x^2 + 1) % n
				if (x < 0)
					x = (x + n) % n; // make sure we're in the bounds of 0-prime

				y = ((y * y + 1) * (y * y + 1) + 1) % n; // unrolled version of ((y^2 + 1)^2 + 1) % n
				if (y < 0)
					y = (y + n) % n; // make sure we're in the bounds of 0-prime
			}
		}

		#endregion

		#region BigInteger Math Modulo

		/// <summary>
		/// Handle modulo of big numbers
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		private static BigInteger MathMod(BigInteger a, BigInteger b)
		{
			return (BigInteger.Abs(a * b) + a) % b;
		}

		#endregion

		#region Diffie Hellman

		public struct DiffieHellmanKey
		{
			public int prime;
			public int generator;
			public int alicePrivate;
			public int alicePublic;

			public int bobPrivate;
			public int bobPublic;
		}

		public static DiffieHellmanKey DiffieHellmanKeyGenerate(int bitCount)
		{
			DiffieHellmanKey dhk = new DiffieHellmanKey();

			dhk.prime = RandomPrimeBlumBlumShub(bitCount);

			// TODO: Specify primitive root count
			dhk.generator = PrimitiveRootSearchAlgorithm(dhk.prime, 5)[4];

			dhk.alicePrivate = BlumBlumShubRandomNumberGenerator() % dhk.prime;
			dhk.alicePublic = (int)FastExponentiationAlgorithm(dhk.generator, dhk.alicePrivate, dhk.prime);

			dhk.bobPrivate = BlumBlumShubRandomNumberGenerator() % dhk.prime;
			dhk.bobPublic = (int)FastExponentiationAlgorithm(dhk.generator, dhk.bobPrivate, dhk.prime);

			return dhk;
		}

		public static long DiffieHellmanKeyEncrypt(int message, int prime, int generator, int alicePrivate, int bobPublic)
		{
			int sharedSecretKey = (int)FastExponentiationAlgorithm(bobPublic, alicePrivate, prime);

			return (int)MathMod(BigInteger.Multiply(message, sharedSecretKey), prime);
		}

		public static int DiffieHellmanKeyDecrypt(long encryptedMsg, int prime, int generator, int bobPrivate, int alicePublic)
		{
			int sharedSecretKey = (int)FastExponentiationAlgorithm(alicePublic, bobPrivate, prime);

			return (int)MathMod(BigInteger.Multiply(encryptedMsg, ModInverse(sharedSecretKey, prime)), prime);
		}

		public static int DiffieHellmanKeyHack(long message, int prime, int generator, int alicePublic, int bobPublic)
		{
			int bobPrivate = BabyStepGiantStepAlgorithm(bobPublic, generator, prime);

			return DiffieHellmanKeyDecrypt(message, prime, generator, bobPrivate, alicePublic);
		}

		#endregion

		#region RSA

		/// <summary>
		/// TODO: Make sure whoever uses this has a correct e
		/// </summary>
		/// <param name="message"></param>
		/// <param name="n"></param>
		/// <param name="e"></param>
		/// <returns></returns>
		public static int RSAEncrypt(int message, int n, int e)
		{
			return (int)FastExponentiationAlgorithm(message, e, n);
		}

		public static int RSADecrypt(int encryptedMessage, int n, int p, int q, int e)
		{
			int phiN = (p - 1) * (q - 1);
			BigInteger d = ModInverse(e, phiN);

			return (int)FastExponentiationAlgorithm(encryptedMessage, d, n);
		}

		public static int RSAHack(int encryptedMessage, int n, int e)
		{
			// find the factors of "n"
			int p = PollardsRhoMethod(n);
			int q = n / p;

			return RSADecrypt(encryptedMessage, n, p, q, e);
		}

		#endregion
	}
}
