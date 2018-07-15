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
		/// Devuelve el CultureInbfo actual
		/// </summary>
		/// <param fileName="codigoIdioma"></param>
		/// <returns></returns>
		/// <exception cref="ex"></exception>
		public static CultureInfo GetActualCuntureInfo( )
		{
			try {
				return Thread.CurrentThread.CurrentCulture;

			} catch( Exception ex ) {
				throw new Exception( "Imposible obtener el idioma (GetActualCuntureInfo): " + ex.Message, ex );
			}

		}
	}
}
