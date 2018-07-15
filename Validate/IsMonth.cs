using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Help.Validates
{
	public partial class HelperValidate
	{
		/// <summary>
		/// Indica si un número de més es correcto o no (1-12)
		/// </summary>
		/// <param name="nMonthOrder"></param>
		/// <returns></returns>
		public static bool IsMonth( int nMonthOrder )
		{
			return ( nMonthOrder >= 1 && nMonthOrder <= 12 );
		}


	}
}
