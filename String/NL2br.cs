using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Help.Strings
{
	public partial class HelperString
	{
		/// <summary>
		/// Sustituye los returns (\r\n) por <br />.
		/// Un valor null es exception. Un valor "" devuele ""
		/// </summary>
		/// <param fileName="s">String</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>String</returns>
		public static string nl2br( string str )
		{
			if( null == str ) {
				return null;
			}

			return str.Replace( "\r\n", "<br />" )
					.Replace( "\n", "<br />" )
					.Replace( "\r", "<br />" );
		}
	}
}
