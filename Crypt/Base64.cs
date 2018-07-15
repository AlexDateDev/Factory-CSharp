using System;

namespace Help.Crypts
{
	public partial class HelperCrypt
	{
		#region base64

		/// <summary>
		/// Encripta un string a Base64
		/// </summary>
		/// <param fileName="cadena">string</param>
		/// <returns>strung</returns>
		/// <exception cref="ex"></exception>
		public static string Base64Crypt( string cadena )
		{
			if( null == cadena ) {
				throw new ArgumentNullException( "No se ha indicado la cadena ha encriptar (Factory.Core.Crypy: CryptBase64)" );
			}
			byte[] cadenaByte = System.Text.Encoding.UTF8.GetBytes( cadena );
			string encodedCadena = Convert.ToBase64String( cadenaByte );
			return encodedCadena;
		}

		/// <summary>
		/// Desencripta un texto encriptado en base64
		/// </summary>
		/// <param fileName="cadena">string</param>
		/// <returns></returns>
		public static string Base64Decrypt( string cadena_encriptada )
		{
			if( null == cadena_encriptada ) {
				throw new ArgumentNullException( "No se ha indicado la cadena para desencriptar (Factory.Core.Crypy: DecryptBase64)" );
			}
			var encoder = new System.Text.UTF8Encoding( );
			var utf8Decode = encoder.GetDecoder( );

			byte[] cadenaByte = Convert.FromBase64String( cadena_encriptada );
			int charCount = utf8Decode.GetCharCount( cadenaByte, 0, cadenaByte.Length );
			char[] decodedChar = new char[ charCount ];
			utf8Decode.GetChars( cadenaByte, 0, cadenaByte.Length, decodedChar, 0 );
			string result = new System.String( decodedChar );
			return result;
		}
		#endregion
	}
}