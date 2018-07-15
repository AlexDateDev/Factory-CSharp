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
		/// Devuelve true si es un número de teléfono de movil.
		/// </summary>
		/// <param fileName="sPhoneMobile">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>bool</returns>
		public static bool IsPhoneMobile( string sPhoneMobile )
		{
			if( null == sPhoneMobile ) {
				return false;
			}
			try {
				sPhoneMobile = sPhoneMobile.Trim( );
				bool formatoOk = Regex.IsMatch( sPhoneMobile, @"^[0-9]+$" ) && ( sPhoneMobile.Length == 9 );
				if( !formatoOk ) {
					return false;
				}
				return sPhoneMobile[ 0 ] == '6';
			} catch( Exception ex ) {
				throw new Exception( "Imposible determinar si es un número de teléfono móbil válido (Validate: IsPhoneMobile): " + ex.Message, ex );
			}
		}

	}
}
