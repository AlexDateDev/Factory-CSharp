using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{
		public static string FillPadRight( string src, int len, char pad = ' ' )
		{
			return src.PadRight( len, pad ).Substring( 0, len );
		}
	}
}
