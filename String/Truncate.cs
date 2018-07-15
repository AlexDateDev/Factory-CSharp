using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{
		/// <summary>
		/// Trunca un string a un número determinado de caracteres. Pasandole un fill agregado al final.
		/// len ha de ser mayor que 0 sino devuelve "".  Un valor "" devuelve ""
		/// Si la longitud a cortar es mayor que str.len devuelve el mismo str (sin concatenar nada)
		/// </summary>
		/// <param fileName="str">string</param>
		/// <param fileName="len">int</param>
		/// <param fileName="fill">string</param>
		/// <returns></returns>
		public static string Truncate( string str, int len, string fill = "" )
		{
			if( null == str ) {
				return null;
			}

			if( len < 0 ) {
				return "";
			}
			string ret = str;
			if( str.Length > len ) {
				ret = str.Substring( 0, len ) + fill;
			}
			return ret;
		}
	}
}
