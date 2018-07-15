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
		/// Comprueba si el string és un número de teléfono (fijo o movil)
		/// </summary>
		/// <param fileName="sPhone">sting</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>bool</returns>
		public static bool IsPhone( string sPhone )
		{
			try {
				if( null == sPhone ) {
					return false;
				}
				return IsPhoneFix( sPhone ) || IsPhoneMobile( sPhone );
			} catch( Exception ex ) {
				throw new Exception( "Imposible determinar si es un número de teléfono válido (Validate: IsPhone): " + ex.Message, ex );
			}
		}


	}
}
