// ----------------------------------------------------------------------------
// Título:    DeleteKey
//
// Fecha:     01/07/2016
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Utils.WebSessions
{
    public partial class FactoryWebSession
    {
        /// <summary>
        /// Elimina una variable guardada en la session.
        /// </summary>
        /// <exception cref="ex"></exception>
        /// <param name="key"></param>
        public static void DeleteKey( string key )
        {
            if( null == key  ) {
                throw new ArgumentNullException( "No se ha indicado clave (" + key + ") en la sesiÃ³n (FactoryWebSession: Clear)" );
            }
            HttpContext.Current.Session.Remove( key );
        }

    }
}
