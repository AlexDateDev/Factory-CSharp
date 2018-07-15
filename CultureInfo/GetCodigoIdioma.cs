// ----------------------------------------------------------------------------
// Título:    GetCodigoIdioma
//
// Fecha:     22/06/2016
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Threading;

namespace Utils.Idiomas
{
    /// <summary>
    /// FactoryLanguage
    /// </summary>
    public partial class FactoryLanguage
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
