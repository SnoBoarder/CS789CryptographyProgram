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
		public static int EuclideanAlgorithm(int x, int y)
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
	}
}
