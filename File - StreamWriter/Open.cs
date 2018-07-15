using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;


namespace Help.Files
{
	public partial class HelperStreamWriter
	{
		/// <summary>
		/// Devuelve el StreamWriter para escribir
		/// </summary>
		/// <param name="fullPath"></param>
		/// <returns></returns>
		public static StreamWriter Open( string fullPath, bool appendText )
		{
			return new StreamWriter( fullPath, appendText, System.Text.Encoding.Default );
		}

	}
}
