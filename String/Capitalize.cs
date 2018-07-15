using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{
		/// <summary>
		/// Pone la primera letra del string o frase en mayúsculas.
		/// Las demas letras las deja igual. 
		/// </summary>
		/// <param fileName="input"></param>
		/// <returns></returns>
		public static string Capitalize( string s )
		{
			if( null == s ){
			    return null;
			}
			s = s.Trim( );
			if( s.Length == 0 ) {
				return s;
			}
			return s.Substring( 0, 1 ).ToUpper( ) + s.Substring( 1, s.Length - 1 );
		}

	}
}
