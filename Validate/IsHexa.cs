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
		/// Indica si un string contiene caracteres Hexadecimales
		/// Acepta como primer caracter el #
		/// </summary>
		/// <param fileName="chars"></param>
		/// <returns></returns>
		public static bool IsHexa( IEnumerable<char> chars )
		{
			if( null == chars ) {
				return false;
			}
			bool isHex = false;
			int n=0;
			foreach( char c in chars ) {
				if( '#' == c && 0 == n ) {
					continue;
				}
				n++;
				isHex = ( ( c >= '0' && c <= '9' ) ||
						 ( c >= 'a' && c <= 'f' ) ||
						 ( c >= 'A' && c <= 'F' ) );

				if( !isHex ) {
					return false;
				}
			}
			return isHex;
		}


	}
}
