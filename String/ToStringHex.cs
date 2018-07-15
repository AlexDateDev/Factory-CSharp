// ----------------------------------------------------------------------------
// Título:    ToStringHex
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
        /// Converts un array de bytes en un string of hex characters
        /// </summary>
        /// <param fileName="strHexa"></param>
        /// <returns></returns>
        protected static string ToStringHex( byte[ ] data )
        {
            if( null == data ) {
                return null;
            }
            StringBuilder results = new StringBuilder( );

            foreach( byte b in data ) {
                results.Append( b.ToString( "X2" ) );
            }
            return results.ToString( );
        }
    }
}
