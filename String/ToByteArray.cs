using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{
		/// <summary>
		/// Convierte un string de caracteres Hexa en un array de bytes
		/// Cada valor Hexa son 2 caracteres
		/// </summary>            
		/// <param fileName="strHexa"></param>
		/// <returns></returns>
		/// <exception cref="ex">Exception</exception>
		public static byte[ ] ToByteArray( string str, bool isHexa=false )
		{
			if( null == str  ) {
				return null;
			}
			if( isHexa ) {
				try {
					byte[] results = new byte[ str.Length / 2 ];

					for( int i = 0, n = str.Length; i < n; i += 2 ) {
						results[ i / 2 ] = Convert.ToByte( str.Substring( i, 2 ), 16 );
					}

					return results;
				} catch( Exception ex ) {
					throw new Exception( "Imposible devolve array de bytes (String: ToByteArray Hexa): " + ex.Message,ex );
				}

			} else {
				try {
					return Encoding.UTF8.GetBytes( str );
				} catch( Exception ex ) {
					throw new Exception( "Imposible convertir string a array byte (String: ToByteArray): " + ex.Message, ex );
				}

			}
		}
	}
}
