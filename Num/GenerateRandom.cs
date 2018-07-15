using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Numbers
{
	public partial class HelperNumber
	{

		public static int GenerateRandom( )
		{
			return new Random( ).Next( int.MinValue, int.MaxValue );
			
			//Random rnd = new Random();
			//int month = rnd.Next(1, 13); // creates a number between 1 and 12
			//int dice = rnd.Next(1, 7); // creates a number between 1 and 6
			//int card = rnd.Next(52); // creates a number between 0 and 51

		}

		public static int GenerateRandom( int min, int max )
		{
			Random rnd = new Random();
			return rnd.Next(min, max); 
		}
	}
}
