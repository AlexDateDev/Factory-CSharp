// ----------------------------------------------------------------------------
// Título:    ArrayBytesToString
//
// Fecha:     01/07/2016
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils.Strings
{
    public partial class FactoryString
    {
        /// <summary>
        /// Convierte un array de bytes en un string
        /// </summary>
        /// <param fileName="strHexa"></param>
        /// <exception cref="ex"></exception>
        /// <returns></returns>
        public static string ToString( byte[ ] data )
        {
            if( null == data ) {
                return null;
            }
            try {
                return Encoding.UTF8.GetString( data, 0, data.Length );
            } catch( Exception ex ) {
                throw new Exception( "Imposible convertir una rray de bytes a unstring (UtilsString: ToString): " + ex.Message, ex );
            }
        }
    }
}
