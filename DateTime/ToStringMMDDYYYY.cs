using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{
		/// <summary>
		/// Devuelve un string DateTime en formato Ingles (MM/dd/yyyy)
		/// </summary>
		/// <param fileName="dt">DateTime</param>
		/// <param fileName="IncludeHHMMSS">bool</param>
		/// <returns>string</returns>
		public static string ToStringMMDDYYYY( DateTime dt, bool IncludeHHMMSS = false )
		{
			if( IncludeHHMMSS ) {
				return dt.ToString( "MM/dd/yyyy HH:mm:ss" );
			} else {
				return dt.ToString( "MM/dd/yyyy" );
			}
		}

	}
}
