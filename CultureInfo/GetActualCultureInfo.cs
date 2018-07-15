// ----------------------------------------------------------------------------
// Título:    GetActualCultureInfo
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
