using System;
using System.Collections.Generic;
using System.Text;

namespace Lynq
{
    class Day25task
    {
		public static void Main()
		{
			int eye, Legs;
			 eye =Convert.ToInt32( Console.ReadLine());
			 Legs =Convert.ToInt32( Console.ReadLine());
			int count = 0;
			int count2 = 0;

			count = 2 * (eye) - (Legs);
			count = count / 2;
			count2 = 26 - count;
			Console.WriteLine("No of Ducks: {0}", count);
			Console.WriteLine("No of Goats: {0}", count2);
		}

	}
}
