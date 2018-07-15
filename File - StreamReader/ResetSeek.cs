using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Help.Files
{
	public partial class HelperStreamReader
	{

		
		public static void ResetSeek( StreamReader SReader)
		{
			SReader.BaseStream.Position = 0;
			SReader.DiscardBufferedData( );
		}

	}
}
