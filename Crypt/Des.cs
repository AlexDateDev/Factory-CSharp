using System.Security.Cryptography;
using System.Text;
using System.IO;
using System;

namespace Help.Crypts
{
	public partial class HelperCrypt
	{
		protected static readonly string _keyString = "ABC12345";
		protected static readonly byte[] _keyBytes = { 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18 };


		/// <summary>
		/// Devuelve un DES de un string. Se utiliza para pasar parámetros por la url.
		/// </summary>
		/// <param fileName="text"></param>
		/// <returns></returns>
		/// <exception cref="ex">Exception</exception>
		public static string DesCrypt( string text )
		{
			try {
				byte[] keyData = Encoding.UTF8.GetBytes( _keyString.Substring( 0, 8 ) );
				DESCryptoServiceProvider des = new DESCryptoServiceProvider( );
				byte[] textData = Encoding.UTF8.GetBytes( text );
				MemoryStream ms = new MemoryStream( );
				CryptoStream cs = new CryptoStream( ms, des.CreateEncryptor( keyData, _keyBytes ), CryptoStreamMode.Write );
				cs.Write( textData, 0, textData.Length );
				cs.FlushFinalBlock( );
				return GetString( ms.ToArray( ) );

			} catch( Exception ex ) {
				throw new Exception( "Imposible encriptar con DES (FactoryCrypt: DesCrypt)", ex );
			}
		}


		/// <summary>
		/// Desencripta in string enciptdo con DES.
		/// </summary>
		/// <param fileName="text">string</param>
		/// <returns>String</returns>
		/// <exception cref="ex">Exception</exception>
		public static string DesDecrypt( string text )
		{
			try {
				byte[] keyData = Encoding.UTF8.GetBytes( _keyString.Substring( 0, 8 ) );
				DESCryptoServiceProvider des = new DESCryptoServiceProvider( );
				byte[] textData = GetByteArray( text );
				MemoryStream ms = new MemoryStream( );
				CryptoStream cs = new CryptoStream( ms, des.CreateDecryptor( keyData, _keyBytes ), CryptoStreamMode.Write );
				cs.Write( textData, 0, textData.Length );
				cs.FlushFinalBlock( );
				return Encoding.UTF8.GetString( ms.ToArray( ) );
			} catch( Exception ex ) {
				throw new Exception( "Imposible desencriptar con DES (Factory.Core.FactoryCrypt: DecryptByDES)", ex );
			}
		}

		/// <summary>
		/// Converts a string of hex characters to a byte array
		/// </summary>            
		/// <param fileName="data"></param>
		/// <returns></returns>
		/// <exception cref="ex">Exception</exception>
		private static byte[ ] GetByteArray( string data )
		{
			try {
				byte[] results = new byte[ data.Length / 2 ];

				for( int i = 0; i < data.Length; i += 2 ) {
					results[ i / 2 ] = Convert.ToByte( data.Substring( i, 2 ), 16 );
				}

				return results;
			} catch( Exception ex ) {
				throw new Exception( "Imposible devilve array de bytes (Factory.Core.FactoryCrypt: GetByteArray)", ex );
			}
		}

		/// <summary>
		/// Converts a byte array to a string of hex characters
		/// </summary>
		/// <param fileName="data"></param>
		/// <returns></returns>
		/// <exception cref="ex">Exception</exception>
		private static string GetString( byte[ ] data )
		{
			try {
				StringBuilder results = new StringBuilder( );

				foreach( byte b in data ) {
					results.Append( b.ToString( "X2" ) );
				}

				return results.ToString( );
			} catch( Exception ex ) {
				throw new Exception( "Imposible convertir un string de un array de bytes (Factory.Core.FactoryCrypt: GetString)", ex );
			}
		}
	}
}