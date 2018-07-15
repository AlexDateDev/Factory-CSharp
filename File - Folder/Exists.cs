using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Help.Files
{
	public partial class HelperFile
	{

		// Comprueba si existe un archivo
		public static bool ExistsFile( string fullPath )
		{
			return File.Exists( fullPath );
		}

	}
}
