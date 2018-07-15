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
		/// Devuelve true si contiene una fecha válida o false si no es valida o null.
		/// Puede tener o no hora pero ha de ser válida.
		/// El formato ha de coincidir con CultureInfo
		/// </summary>
		/// <param fileName="sDate">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>bool</returns>
		public static bool IsDate( string sDate )
		{
			if( null == sDate ) {
				return false;
			}

			System.DateTime dt;
			if( System.DateTime.TryParse( sDate, out dt ) ) {
				return true;
			}
			return false;
		}

	}
}
