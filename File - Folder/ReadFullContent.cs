using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Help.Files
{
	public partial class HelperFile
	{
		/// <summary>
		/// Devuelve el contenido de archivo como un array de byte[]
		/// </summary>
		/// <param name="FullPath">string</param>
		/// <returns>byte[ ]</returns>
		/// <exception cref="ex">Exception</exception>
		public static byte[ ] ReadFullContent( string FullPath )
		{
			if( null == FullPath ) {
				throw new ArgumentNullException( "No se ha indicado el path del archivo (FactoryFile: ReadFullContent)" );
			}
			try {
				FileInfo fileInfo = new FileInfo( FullPath );

				// The byte[] to save the data in
				byte[] data = new byte[ fileInfo.Length ];

				// Load a filestream and put its content into the byte[]
				using( FileStream fs = fileInfo.OpenRead( ) ) {
					fs.Read( data, 0, data.Length );
				}
				return data;
			} catch( Exception ex ) {
				throw new Exception( "Error al leer archivo (FactoryFile: ReadFullContent): " + ex.Message, ex );
			}
		}
	}
}
