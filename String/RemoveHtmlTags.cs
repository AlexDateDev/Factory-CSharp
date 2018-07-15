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
		/// Devuelve el string sin tags html. 
		/// Un valor null es exception. Un valor "" devuele ""
		/// </summary>
		/// <param fileName="str">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>string</returns>
		public static string RemoveHtmlTags( string str )
		{
			if( null == str ) {
				return null;
			}
			return Regex.Replace( str, "<[^>]*>", string.Empty );
		}
	}
}
