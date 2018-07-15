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
		/// Devuelve true si es un número de teléfono fijo.
		/// </summary>
		/// <param fileName="sPhoneFix">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>bool</returns>
		public static bool IsPhoneFix( string sPhoneFix )
		{
			if( null == sPhoneFix ) {
				return false;
			}
			try {
				sPhoneFix = sPhoneFix.Trim( );
				bool formatoOk = Regex.IsMatch( sPhoneFix, @"^[0-9]+$" ) && ( sPhoneFix.Length == 9 );
				if( !formatoOk ) {
					return false;
				}
				bool IdProvincia2Ok = false;
				bool IdProvincia3Ok = false;

				string sCode = sPhoneFix.Substring( 0, 2 );
				switch( sCode ) {
					case "91": // -- Madrid        91
					case "93": // -- Barcelona    93
					case "94": // -- Vizcaya        94
					case "95": // -- Sevilla        95
					case "96": // -- Alicante        96
					case "98": // -- Asturias        98
						IdProvincia2Ok = true;
						break;
					default:
						break;
				}

				sCode = sPhoneFix.Substring( 0, 3 );
				switch( sCode ) {
					case "923": // -- Salamanca    923
					case "973": // -- Lleida        973
					case "921": // -- Segovia        921
					case "926": // -- Ciudad Real    926
					case "975": // -- Soria        975
					case "977": // -- Tarragona    977
					case "920": // -- Avila        920
					case "922": // -- Tenerife    922
					case "924": // -- Badajoz        924
					case "972": // -- Girona        972
					case "978": // -- Teruel        978
					case "971": // -- Baleares    971
					case "925": // -- Toledo        925
					case "979": // -- Palencia    979
					case "927": // -- Cáceres        927
					case "928": // -- Palmas, Las    928
					case "974": // -- Huesca        974
					case "976": // -- Zaragoza    976
						IdProvincia3Ok = true;
						break;
					default:
						break;
				}
				return ( IdProvincia2Ok || IdProvincia3Ok );
			} catch( Exception ex ) {
				throw new Exception( "Imposible determinar si es un número de teléfono fijo válido (Validate: IsPhoneFix): " + ex.Message, ex );
			}
		}
	}
}
