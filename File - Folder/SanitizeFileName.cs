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
		/// // Devuelve un nombre de archivo válido. Sin caracteres no permitidos que son sustiruidos por "_"
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		private static string SanitizeFileName( string fileName, string charSubstitute="_" )
		{			         
			string invalidChars = System.Text.RegularExpressions.Regex.Escape( new string( System.IO.Path.GetInvalidFileNameChars( ) ) );
			string invalidReStr = string.Format( @"([{0}]*\.+$)|([{0}]+)", invalidChars );
			return System.Text.RegularExpressions.Regex.Replace( fileName, invalidReStr, charSubstitute );
		}



	}
}
