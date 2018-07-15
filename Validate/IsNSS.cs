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
		/// Validación de un número de la seguridad social
		/// </summary>
		/// <param name="sNSS"></param>
		/// <returns></returns>
		public static bool IsNSS( string sNSS )
		{
			if( sNSS == null ) return false;
			if( sNSS.Length != 11 && sNSS.Length != 12 ) return false;
			if( int.Parse( sNSS.Substring( 2, 1 ) ) == 0 )
				sNSS = "" + sNSS.Substring( 0, 2 ) + sNSS.Substring( 3, sNSS.Length - 1 );
			if( Int64.Parse( sNSS.Substring( 0, sNSS.Length - 2 ) ) % 97 == Int64.Parse( sNSS.Substring( sNSS.Length - 2, 2 ) ) ) {
				return true;
			} else return false;
		}




	}
}
