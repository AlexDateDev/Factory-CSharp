
using System.Security.Cryptography;
using System;
using System.Text;

namespace Help.Crypts
{
	public partial class HelperCrypt
	{

		/// <summary>
		/// Calcula el SHA1 de un string. Ej. "D20019FC692C669E3FC558CD9279AA58"
		/// Si str es null, devuelve null. "" tiene SHA1
		/// </summary>
		/// <param fileName="input">string a calcuar su SHA1</param>
		/// <returns>string</returns>
		/// <exception cref="ex">Exception</exception>
		public static string CalculateSHA1Hash( string str )
		{
			if( null == str ) {
				throw new ArgumentNullException( "No se ha indicado la cadena para calcular SHA1 (Factory.Core.Crypy: CalculateSHA1Hash)" );
			}
			try {
				SHA1 cry = SHA1.Create( );
				byte[] inputBytes = Encoding.ASCII.GetBytes( str );
				byte[] hash = cry.ComputeHash( inputBytes );

				// step 2, convert byte array to hex string
				StringBuilder sb = new StringBuilder( );
				for( int i = 0; i < hash.Length; i++ ) {
					sb.Append( hash[ i ].ToString( "X2" ) );
				}
				return sb.ToString( );
			} catch( Exception ex ) {
				throw new Exception( "Imposible calcular SHA1 Hash (Factory.Core.FactoryCrypt: CalculateSHA1Hash)", ex );
			}
		}
	}
}