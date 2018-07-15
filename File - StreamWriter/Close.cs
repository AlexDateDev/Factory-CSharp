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
		/// Cierra un StreamWrite
		/// </summary>
		/// <param name="fullPath"></param>
		/// <returns></returns>
		public static void  Close( StreamWriter SWriter, string txt)
		{
			SWriter.Flush( );
			SWriter.Close( );
		}

	}
}
