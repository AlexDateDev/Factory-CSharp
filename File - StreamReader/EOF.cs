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
		/// Detecta el final del stream
		/// </summary>
		/// <param name="SReader"></param>
		/// <returns></returns>
			
		public static bool EOF( StreamReader SReader)
		{
			return SReader.EndOfStream;
		}

	}
}
