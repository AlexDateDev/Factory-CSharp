using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Numbers
{
	public partial class HelperNumber
	{

		/// <summary>
		/// Convierte un double en un string currency con el símbolo euro. 123456.78 = "123.456,78 €"
		/// Si notiene decimales, se añade ,00. Si hay más de 2 decimales, se trunca por exceso o defecto a 2 dígitos.
		/// Si no se pasa CultureInfo, se utiliza es-es
		/// </summary>
		/// <param fileName="dValue">double</param>
		/// <param fileName="ci">CultureInfo</param>
		/// <exception cref="Exception"></exception>
		/// <returns></returns>
		public static string ToEuro( double dValue, System.Globalization.CultureInfo ci = null )
		{
			try {
				if( null == ci ) {
					ci = new System.Globalization.CultureInfo( "es-es" );
				}
				ci.NumberFormat.CurrencySymbol = "€";
				return dValue.ToString( "C", ci );
			} catch( Exception ex ) {
				throw new Exception( "Imposible convertir a string Euro (num: ToEuro): " + ex.Message, ex );
			}
		}

	}
}
