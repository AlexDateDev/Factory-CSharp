using System;
using System.Globalization;
using System.Threading;

namespace Help.Idiomas
{
	/// <summary>
	/// FactoryLanguage
	/// </summary>
	public partial class HelperLanguage
	{

		/// <summary>
		/// Devuelve un idioma (es-es) actual
		/// </summary>
		/// <param fileName="codigoIdioma"></param>
		/// <returns></returns>
		/// <exception cref="ex"></exception>
		public static string GetCodigoIdioma( )
		{
			try {
				System.Globalization.CultureInfo ci = Thread.CurrentThread.CurrentCulture;
				return ci.Name;

			} catch( Exception ex ) {
				throw new Exception( "Imposible obtener el idioma (GetCodigoIdioma): " + ex.Message );
			}
		}
	}
}
