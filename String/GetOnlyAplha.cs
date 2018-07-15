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
		/// Devuelve un string sólo con letras y números (alfanuméricos). Elimina cualquier caracter que no sea letras o números.
		/// Elimina letras con acentos. Conserva los espacios en blanco.
		/// Un valor null es exception. Un valor "" devuele ""
		/// </summary>
		/// <param fileName="str">String</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>string</returns>
		public static string GetOnlyAlpha( string str )
		{
			if( null == str ) {
				return null;
			}
			return Regex.Replace( str, @"[^a-zA-z0-9 ]+", "" );
		}

	}
}
