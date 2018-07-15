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
		/// Convierte un string a byte
		/// MaxValue = 255.
		/// MinValue = 0.
		/// No convierte números negativos
		/// </summary>
		/// <param fileName="num">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>byte</returns>
		public static byte ToByte( string num )
		{
			byte i =0;
			if( Byte.TryParse( num, out i ) ) {
				return i;
			}
			throw new ArgumentOutOfRangeException( "No se puede convertir un string a byte (String ToByte)" );
		}   
	}
}
