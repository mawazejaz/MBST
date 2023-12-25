namespace BaseLibrary.Wraper
{
	public static class RandomNumber
	{

		public static int GenerateRandomNumber(int digitCount = 7)
		{
			if (digitCount <= 0)
			{
				throw new ArgumentException("Digit count must be greater than 0", nameof(digitCount));
			}

			Random random = new Random();
			int minValue = (int)Math.Pow(10, digitCount - 1);
			int maxValue = (int)Math.Pow(10, digitCount) - 1;

			return random.Next(minValue, maxValue);
		}
	}
}
