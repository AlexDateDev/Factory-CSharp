using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Help.Validates
{
	public partial class HelperValidate
	{
		/// <summary>		
		/// Indica si el string es un email correcto
		/// </summary>
		/// <param fileName="email">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>bool</returns>
		public static bool IsEmail( string email )
		{
			if( null == email ) {
				return false;
			}
			try {
				string pattern = @"^(([^<>()[\]\\.,;:\s@\""]+"
								+ @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
								+ @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
								+ @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
								+ @"[a-zA-Z]{2,}))$";
				return new Regex( pattern ).IsMatch( email );
			} catch( Exception ex ) {
				throw new Exception( "Imposible determinar si es un email válido (Validate: IsEmail): " + ex.Message, ex );
			}
		}
	}
}
