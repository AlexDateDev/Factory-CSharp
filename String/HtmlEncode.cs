using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

// Web
using System.Web;

namespace Help.Strings
{
	public partial class HelperString
	{
		/// <summary>
		// Codifica un string. Utilizado generalmente sobre los strings introducidos por los usuarios
		/// </summary>
		/// <param fileName="str"></param>
		/// <returns></returns>
		public string HtmlEncode( string str )
		{
			return HttpUtility.HtmlEncode( str );
		}

	}
}
