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
		/// Renombra un archivo. No comprueba si destino ya exista
		/// </summary>
		/// <param name="fileDirOrig"></param>
		/// <param name="fileDirEnd"></param>
		void RenameFile( string fileDirOrig, string fileDirEnd )
		{
			try {
				File.Move( fileDirOrig, fileDirEnd );
			} catch( Exception ex ) {
				throw new Exception( "Imposible renombrar archivo " + fileDirOrig + " a " + fileDirEnd + ": " + ex.Message, ex );
			}
		}


	}
}
