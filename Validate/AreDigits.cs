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
		/// Indica si un string esta formado sólo por dígitos.
		/// null o vacio devuelve false
		/// </summary>
		/// <param fileName="str"></param>
		/// <returns></returns>
		public static bool AreDigits( string str )
		{
			if( null == str  ) {
				return false;
			}
			return Regex.IsMatch( str, @"^[0-9]+$" );
			//foreach( char c in str ) {
			//    if( c < '0' || c > '9' )
			//        return false;
			//}
			//return true;
		}
	}
}
