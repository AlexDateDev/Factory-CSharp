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
		/// Indica si un valor esta entre 0 y 100 (incluidos)
		/// </summary>
		/// <param name="d">double: valor a consultar</param>
		/// <returns>booL: true si esta entre los valores o false si no lo esta</returns>
		public static bool IsPercentage( double d )
		{
			return ( d >= 0.0 && d <= 100.00 );
		}



	}
}
