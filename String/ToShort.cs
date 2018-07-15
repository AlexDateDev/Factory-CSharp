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
		/// Convierte un string numérico a short (Int16).
		/// MaxValue = 32767.
		/// MinValue = -32768.
		/// Convierte números positivos  y negativos.
		/// "+123" = 123.
		/// "-123" = -123.
		/// </summary>
		/// <exception cref="ex">Exception</exception>
		/// <param fileName="num">string</param>
		/// <returns>short</returns>
		public static short ToShort( string num )
		{
			short i =0;
			if( Int16.TryParse( num, out i ) ) {
				return i;
			}
			throw new ArgumentOutOfRangeException( "No se puede convertir un string a short (String ToShort)" );
		}
	}
}
