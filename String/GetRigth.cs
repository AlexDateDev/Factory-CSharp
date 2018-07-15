using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{

		// <summary>
		/// Devuelve la parte derecha de un string para una cierta longitud. Empieza a contar desde la derecha
		/// </summary>
		/// <param fileName="str"></param>
		/// <param fileName="length"></param>
		/// <returns></returns>
		public static string GetRight( string str, int length )
		{
			if( null == str ) {
				return null;
			}
			if( length < 0 ) {
				length = 0;
			}
			int begin = str.Length - length;
			if( begin < 0 ) {
				begin = 0;
			}
			if( length > str.Length ) {
				length = str.Length;
			}

			return str.Substring( begin, length );
		}
	}
}
