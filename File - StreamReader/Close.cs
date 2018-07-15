using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Help.Files
{
	public partial class HelperStreamReader
	{

		/// <summary>
		/// Cierra un stream
		/// </summary>
		/// <param name="SReader"></param>
		/// <returns></returns>
		public static void Close( StreamReader SReader)
		{
			SReader.Close( );
		}

	}
}
