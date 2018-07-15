// ----------------------------------------------------------------------------
// Título:    GetLedt
//
// Fecha:     01/07/2013
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
        /// Devuelve la parte izquierda de un string hasta una cierta longitud. Empieza a contar desde la izquierda. null devuelve null
        /// </summary>
        /// <param fileName="str"></param>
        /// <param fileName="length"></param>
        /// <returns></returns>
        public static string GetLeft( string str, int length )
        {
            if( null == str  ) {
                return null;
            }

            if( length < 0 ) {
                length = 0;
            }

            if( length > str.Length ) {
                length = str.Length;
            }
            return str.Substring( 0, length );
        }

    }
}
