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
		/// Devuelve una línea del stream
		/// </summary>
		/// <param name="SReader"></param>
		/// <returns></returns>
		public static string ReadLine( StreamReader SReader)
		{
			return SReader.ReadLine( );
		}

	}
}
