using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Help.Strings
{
	public partial class HelperString
	{
		/// <summary>
		/// Convertir un String a Int (32 bits) o null si no se ha podido convertir.
		/// MaxValue = 2147483647.
		/// MinValue = -2147483648.
		/// Convierte números positivos  y negativos.
		/// "+123" = 123.
		/// "-123" = -123.
		/// </summary>
		/// <param fileName="num">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>int</returns>
		public static int ToInt( string num )
		{
			int i =0;
			if( Int32.TryParse( num, out i ) ) {
				return i;
			}
			throw new ArgumentOutOfRangeException( "No se puede convertir un string a int (String ToInt)" );
		}
	}
}
