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
		/// Renombra un directorio. No comprueba si destino ya exista
		/// </summary>
		/// <param name="dirOrig"></param>
		/// <param name="dirEnd"></param>
		void RenameFolder( string dirOrig, string dirEnd )
		{
			try {
				Directory.Move( dirOrig, dirEnd);
			} catch( Exception ex ) {
				throw new Exception( "Imposible renombrar directorio " + dirOrig + " a " + dirEnd + ": " + ex.Message, ex );
			}
		}


	}
}
