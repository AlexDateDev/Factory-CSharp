using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{

		public static string FillPadLeft( string src, int len, char pad = ' ' )
		{
			string ret = src.PadLeft( len, pad );
			return ret.Substring( ret.Length - len, len );
		}

	}
}
