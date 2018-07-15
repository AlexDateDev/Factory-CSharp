using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Help.Validates
{
	public partial class HelperValidate
	{
		/// <summary>
		/// Devuelve true si el objeto es un string o false en otro caso
		/// </summary>
		/// <param fileName="obj">object</param>
		/// <returns>bool</returns>
		public static bool IsString( object obj )
		{
			return !( null == obj || !( obj is string ) );
		}

	}
}
