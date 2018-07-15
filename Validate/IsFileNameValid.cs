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
		/// Indica si el nombre del archivo es válido. Cumple con las especificaciones del Sistema Operatativo.
		/// Si contiene algún caracter no valido devuelve false.
		/// Valores NO válidos: "&lt;&gt;&amp;&#124;&#42;&#63;
		/// </summary>
		/// <param fileName="testName">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>bool</returns>
		public static bool IsFileNameValid( string fileName )
		{
			if( null == fileName ) {
				return false;
			}
			try {
				// No válidos
				// \"<>\\|\0\a\b\\t\\n\v\\f\\r:\\*\\?\\\\/
				string invalidChars = Regex.Escape( new string( System.IO.Path.GetInvalidFileNameChars( ) ) );
				Regex containsABadCharacter = new Regex( "[" + invalidChars + "]" );
				if( containsABadCharacter.IsMatch( fileName ) ) {
					return false;
				};
				return true;
			} catch( Exception ex ) {
				throw new Exception( "Imposible determinar si es un nombre de archivo válido (Validate: IsFileNameValid): " + ex.Message, ex );
			}
		}

	}
}
