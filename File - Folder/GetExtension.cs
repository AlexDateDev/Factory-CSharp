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
		/// Devuelve la extensión del archivo
		/// </summary>
		/// <param name="fullPath"></param>
		/// <returns></returns>
		public static string GetExtension( string fullPath )
		{
			if( null == fullPath ) {
				throw new ArgumentNullException( "No se ha indicado el path del archivo (FactoryFile: GetExtension)" );
			}
			try {
				FileInfo fileInfo = new FileInfo( fullPath );

				// The byte[] to save the data in
				return fileInfo.Extension;

			} catch( Exception ex ) {
				throw new Exception( "Error al obtener el tamaño del archivo (FactoryFile: GetExtension): " + ex.Message, ex );
			}
		}
	}
}
