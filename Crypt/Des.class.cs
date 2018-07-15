#region Using

using System;
using System.Security.Cryptography;
using System.Text;

#endregion

namespace Help.Crypts
{
	/// <summary>
	/// Rijndael Encryptor / Decryptor Helper
	/// 
	/// <remarks>
	/// Created by: Jafet Sanchez 
	/// Last Update: [date],[author],[description]
	/// 
	public class HelperDesStd
	{
		#region Private/Protected Member Variables

		/// <summary>
		/// Decryptor
		/// 
		private readonly ICryptoTransform _decryptor;

		/// <summary>
		/// Encryptor
		/// 
		private readonly ICryptoTransform _encryptor;

		/// <summary>
		/// 16-byte Private Key
		/// 
		private static readonly byte[] IV = Encoding.UTF8.GetBytes( "AuLmdDw}GVvFw*}g" );

		/// <summary>
		/// Public Key
		/// 
		private readonly byte[] _password;

		/// <summary>
		/// Rijndael cipher algorithm
		/// 
		private readonly RijndaelManaged _cipher;

		#endregion

		#region Private/Protected Properties

		private ICryptoTransform Decryptor { get { return _decryptor; } }
		private ICryptoTransform Encryptor { get { return _encryptor; } }

		#endregion

		#region Private/Protected Methods
		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// 
		/// <param fileName="password">Public key
		public HelperDesStd( string password )
		{
			if( null == password ) {
				throw new ArgumentNullException( "No se ha indicado el password para encruptar (Factory.Core.CryptDesStd: constructor)" );
			}
			//Encode digest
			var md5 = new MD5CryptoServiceProvider( );
			_password = md5.ComputeHash( Encoding.ASCII.GetBytes( password ) );

			//Initialize objects
			_cipher = new RijndaelManaged( );
			_decryptor = _cipher.CreateDecryptor( _password, IV );
			_encryptor = _cipher.CreateEncryptor( _password, IV );

		}

		#endregion

		#region Public Properties
		#endregion

		#region Public Methods

		/// <summary>
		/// Decryptor
		/// 
		/// <param fileName="text">Base64 string to be decrypted
		/// <returns>
		public string Decrypt( string text )
		{
			if( null == text ) {
				throw new ArgumentNullException( "No se ha indicado texto a desencriptar (Factory.Core.CryptDesStd: Decrypt)" );
			}

			try {
				byte[] input = Convert.FromBase64String( text );

				var newClearData = Decryptor.TransformFinalBlock( input, 0, input.Length );
				return Encoding.ASCII.GetString( newClearData );

			} catch( ArgumentException ae ) {
				throw new Exception( "inputCount uses an invalid value or inputBuffer has an invalid offset length. " + ae );

			} catch( ObjectDisposedException oe ) {
				throw new Exception( "The object has already been disposed." + oe );
			}


		}

		/// <summary>
		/// Encryptor
		/// 
		/// <param fileName="text">String to be encrypted
		/// <returns>
		public string Encrypt( string text )
		{
			if( null == text ) {
				throw new ArgumentNullException( "No se ha indicado texto a encriptar (Factory.Core.CryptDesStd: Encrypt)" );
			}

			try {
				var buffer = Encoding.ASCII.GetBytes( text );
				return Convert.ToBase64String( Encryptor.TransformFinalBlock( buffer, 0, buffer.Length ) );

			} catch( ArgumentException ae ) {
				throw new Exception( "inputCount uses an invalid value or inputBuffer has an invalid offset length. " + ae );
			} catch( ObjectDisposedException oe ) {
				throw new Exception(  "The object has already been disposed." + oe );
			}

		}

		#endregion
	}
}