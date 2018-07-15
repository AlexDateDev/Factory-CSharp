// ----------------------------------------------------------------------------
// Título:    SetCodigoIdioma
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
        /// Asignar un idioma (es-es) como actual
        /// </summary>
        /// <param fileName="codigoIdioma"></param>
        /// <exception cref="ex"></exception>
        public static void SetCodigoIdioma( string codigoIdioma )
        {
            if( null == codigoIdioma ) {
                throw new ArgumentNullException( "No se ha indicado el cÃ³digo del idioma (SetCodigoIdioma)" );
            }
            try {
                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo( codigoIdioma );

                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
            } catch( Exception ex ) {
                throw new Exception( "Imposible asignar el idioma (codigoIdioma): " + ex.Message, ex );
            }

        }
    }
}
