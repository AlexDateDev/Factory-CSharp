using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Help.Strings
{
	public partial class HelperString
	{
		/// <summary>
		/// Convierte un string en un string con formato HTML
		/// </summary>
		/// <param fileName="str"></param>
		/// <returns></returns>
		public static string ToHtml( string str )
		{
			return nl2br( HttpUtility.HtmlEncode( str ) );
		}

	}
}
