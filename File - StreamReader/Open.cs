using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;


namespace Help.Files
{
	public partial class HelperStreamReader
	{
		/// <summary>
		/// Devuelve el StreamReader para leer
		/// </summary>
		/// <param name="fullPath"></param>
		/// <returns></returns>
		public static StreamReader Open( string fullPath )
		{
			return new StreamReader( fullPath, System.Text.Encoding.Default );
		}

	}
}
