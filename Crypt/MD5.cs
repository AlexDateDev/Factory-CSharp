
using System.Security.Cryptography;
using System;
using System.Text;

namespace Help.Crypts
{
	public partial class HelperCrypt
	{

		/// <summary>
		/// Calcula el MD5 de un string. Ej. "D20019FC692C669E3FC558CD9279AA58"
		/// Si str es null, devuelve null. "" tiene MD5
		/// </summary>
		/// <param fileName="input">string</param>
		/// <returns>string</returns>
		/// <exception cref="ex">Exception</exception>
		public static string CalculateMD5Hash( string str )
		{
			if( null == str ) {
				throw new ArgumentNullException( "No se ha indicado la cadena para calcular MD5 (Factory.Core.Crypy: CalculateSHA1Hash)" );

			}
			try {

				// step 1, calculate MD5 hash from input
				MD5 md5 = MD5.Create( );
				byte[] inputBytes = Encoding.ASCII.GetBytes( str );
				byte[] hash = md5.ComputeHash( inputBytes );

				// step 2, convert byte array to hex string
				StringBuilder sb = new StringBuilder( );
				for( int i = 0; i < hash.Length; i++ ) {
					sb.Append( hash[ i ].ToString( "X2" ) );
				}
				return sb.ToString( );
			} catch( Exception ex ) {
				throw new Exception( "Imposible calcular MD5 Hash (Factory.Core.FactoryCrypt: CalculateMD5Hash)", ex );
			}
		}
	}
}