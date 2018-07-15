
using System.Security.Cryptography;
using System;
using System.Text;
using System.IO;

namespace Help.Crypts
{
	public partial class HelperCrypt
	{
		/// <summary>
		/// /// <summary>
		/// Método para encriptar un texto plano usando el algoritmo (Rijndael).
		/// Este es el mas simple posible, muchos de los datos necesarios los
		/// definimos como constantes.
		/// </summary>
		/// <param fileName="str">string</param>
		/// <param fileName="pass">string</param>
		/// <returns>string</returns>
		/// <exception cref="ex">Exception</exception>
		public static string CryptString( string str, string pass )
		{
			try {
				return RijndaelCrypt( str,
										pass,
										"s@lAvz", 			// Salto
										"MD5",				// Algoritmo
										1,					// Iteraciones
										"@1B2c3D4e5F6g7H8", // Vector (16 char)
										128					// Tama´ño clave
										);
			} catch( Exception ex ) {
				throw ex;
			}
		}

		/// <summary>
		/// Método para desencriptar un texto encriptado mediante Rijndael.
		/// </summary>
		/// <param fileName="str">string</param>
		/// <param fileName="pass">string</param>
		/// <returns>string</returns>
		/// <exception cref="ex">Exception</exception>
		public static string DecryptString( string str, string pass )
		{
			try {
				return RijndaelDecrypt( str,
										pass,
										"s@lAvz", 			// Salto
										"MD5",				// Algoritmo
										1,					// Iteraciones
										"@1B2c3D4e5F6g7H8", // Vector (16 char)
										128					// Tama´ño clave
										);
			} catch( Exception ex ) {
				throw ex;
			}
		}

		/// <summary>
		/// Método para desencriptar un texto encriptado (Rijndael)
		/// </summary>
		/// <param fileName="textoEncriptado">Texto encriptado</param>
		/// <param fileName="passBase">Passord para desencriptar</param>
		/// <param fileName="saltValue">Salto</param>
		/// <param fileName="hashAlgorithm">Tipo Algoritmo</param>
		/// <param fileName="passwordIterations">Password para la iteración</param>
		/// <param fileName="initVector">Vetos de valroes</param>
		/// <param fileName="keySize">Clave</param>
		/// <returns>string</returns>
		/// <exception cref="ex">Exception</exception>
		private static string RijndaelDecrypt( string textoEncriptado,
											string passBase,
											string saltValue,
											string hashAlgorithm,
											int passwordIterations,
											string initVector,
											int keySize )
		{
			try {
				byte[] initVectorBytes = Encoding.ASCII.GetBytes( initVector );
				byte[] saltValueBytes = Encoding.ASCII.GetBytes( saltValue );
				byte[] cipherTextBytes = Convert.FromBase64String( textoEncriptado );

				PasswordDeriveBytes password = new PasswordDeriveBytes( passBase,
																		saltValueBytes,
																		hashAlgorithm,
																		passwordIterations );
				byte[] keyBytes = password.GetBytes( keySize / 8 );
				RijndaelManaged symmetricKey = new RijndaelManaged( ) {
					Mode = CipherMode.CBC
				};

				ICryptoTransform decryptor = symmetricKey.CreateDecryptor( keyBytes, initVectorBytes );

				MemoryStream memoryStream = new MemoryStream( cipherTextBytes );

				CryptoStream cryptoStream = new CryptoStream( memoryStream, decryptor, CryptoStreamMode.Read );

				byte[] plainTextBytes = new byte[ cipherTextBytes.Length ];
				int decryptedByteCount = cryptoStream.Read( plainTextBytes, 0, plainTextBytes.Length );
				memoryStream.Close( );
				cryptoStream.Close( );
				return Encoding.UTF8.GetString( plainTextBytes, 0, decryptedByteCount );

			} catch( Exception ex ) {
				throw new Exception( "Imposible desencriptar con algoritmo Rijndael (Factory.Core.FactoryCrypt: Desencriptar)", ex );
			}
		}


		/// <summary>
		/// Método para encriptar un texto plano usando el algoritmo (Rijndael)
		/// </summary>
		/// <param fileName="textoEncriptado">Texto a encriptar</param>
		/// <param fileName="passBase">Passord para desencriptar</param>
		/// <param fileName="saltValue">Salto</param>
		/// <param fileName="hashAlgorithm">Tipo Algoritmo</param>
		/// <param fileName="passwordIterations">Password para la iteración</param>
		/// <param fileName="initVector">Vetos de valroes</param>
		/// <param fileName="keySize">Clave</param>
		/// <returns>string</returns>
		/// <exception cref="ex">Exception</exception>
		private static string RijndaelCrypt( string textoQueEncriptaremos,
										string passBase,
										string saltValue,
										string hashAlgorithm,
										int passwordIterations,
										string initVector,
										int keySize )
		{
			try {
				byte[] initVectorBytes = Encoding.ASCII.GetBytes( initVector );
				byte[] saltValueBytes = Encoding.ASCII.GetBytes( saltValue );
				byte[] plainTextBytes = Encoding.UTF8.GetBytes( textoQueEncriptaremos );

				PasswordDeriveBytes password = new PasswordDeriveBytes( passBase,
																		saltValueBytes,
																		hashAlgorithm,
																		passwordIterations );

				byte[] keyBytes = password.GetBytes( keySize / 8 );

				RijndaelManaged symmetricKey = new RijndaelManaged( ) {
					Mode = CipherMode.CBC
				};

				ICryptoTransform encryptor = symmetricKey.CreateEncryptor( keyBytes, initVectorBytes );

				MemoryStream memoryStream = new MemoryStream( );
				CryptoStream cryptoStream = new CryptoStream( memoryStream, encryptor, CryptoStreamMode.Write );

				cryptoStream.Write( plainTextBytes, 0, plainTextBytes.Length );
				cryptoStream.FlushFinalBlock( );
				byte[] cipherTextBytes = memoryStream.ToArray( );
				memoryStream.Close( );
				cryptoStream.Close( );
				return Convert.ToBase64String( cipherTextBytes );
			} catch( Exception ex ) {
				throw new Exception( "Imposible encriptar con algoritmo Rijndael (Factory.Core.FactoryCrypt: Encriptar)", ex );
			}
		}
	}

}