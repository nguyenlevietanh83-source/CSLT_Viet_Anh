using System;
namespace Buoi_3
{
	public class ref_out
	{
		static void Main(string[]args)
		{
			int value = 5;
			Console.WriteLine("Value before increase: {0}", value);
			IncreaseValue(value);
            Console.WriteLine("Value after increase: {0}", value);

            Console.ReadLine();
		}
		static void IncreaseValue(int value)
		{
			value++;

		}
	}
}

