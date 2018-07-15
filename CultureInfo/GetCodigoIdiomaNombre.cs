// ----------------------------------------------------------------------------
// T�tulo:    GetCodigoIdiomaNombre
//
// Fecha:     22/06/2016
// Autor:    Alex Sol�
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
        /// Devuelve el nombre original del CultureInfo. Español, Català, ... (en mayúsculas)
        /// </summary>
        /// <param fileName="CultureInfo"></param>
        /// <returns></returns>
        /// <exception cref="ex"></exception>
        public static string GetNombreCodigoIdioma( string codigoIdioma )
        {
            if( null == codigoIdioma  ) {
                throw new ArgumentNullException( "No se ha indicado el código del idioma (GetNombreCodigoIdioma)" );
            }
            try {
                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo( codigoIdioma );
                string[] names = ci.NativeName.Split( ' ' );
                string str= names[ 0 ];
                return str.Substring( 0, 1 ).ToUpper( ) + str.Substring( 1, str.Length - 1 ).ToLower( );

            } catch( Exception ex ) {
                throw new Exception( "Imposible determinar el nombre del idioma (GetNombreCodigoIdioma): " + ex.Message, ex );
            }
        }
    }
}
