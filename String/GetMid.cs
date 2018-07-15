using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{

		/// <summary>
		/// Devuelve la parte centrat de un string desde un index hasta un cierto número de caracteres.
		/// Empieza contar desde la izquierda. Incluye la posición begin
		/// </summary>
		/// <param fileName="str"></param>
		/// <param fileName="begin"></param>
		/// <param fileName="length"></param>
		/// <returns></returns>
		public static string GetMid( string str, int begin, int length )
		{
			if( null == str  ) {
				return null;
			}
			if( length < 0 ) {
				length = 0;
			}
			if( begin < 0 ) {
				begin = 0;
			}
			if( begin > str.Length ) {
				return "";
			}
			if( length > str.Length ) {
				length = str.Length;
			}
			string strRet = str.Substring( begin );
			if( strRet.Length < length ) {
				// Pido mas caracteres de los que puedo
				return strRet;
			}
			return str.Substring( begin, length );
		}

	}
}
