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
		/// Escribe una linea
		/// </summary>
		/// <param name="fullPath"></param>
		/// <returns></returns>
		public static void  WriteLine( StreamWriter SWriter, string txt)
		{
			SWriter.WriteLine( txt );
			SWriter.Flush( );
		}

	}
}
