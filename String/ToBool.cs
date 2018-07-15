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
		/// Convierte un valor 1/o en true/false o null si es incorrecto
		/// </summary>
		/// <param fileName="num">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>bool</returns>
		public static bool ToBool( string num )
		{
			bool i;
			if( Boolean.TryParse( num, out i ) ) {
				return i;
			}
			throw new ArgumentOutOfRangeException( "No se puede convertir un string a bool (String ToBool)" );
		}
	}
}
