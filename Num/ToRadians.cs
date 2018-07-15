using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Numbers
{
	public partial class HelperNumber
	{

		/// <summary>
		/// Convert to Radians.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		private static double ToRadians( double val )
		{
			return ( Math.PI / 180d ) * val;
		}


	}
}
