// ----------------------------------------------------------------------------
// T�tulo:    ExistsKey
//
// Fecha:     01/07/2016
// Autor:    Alex Sol�
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
        /// Comprueba si existe una variable determinada en la sesión
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="ex">Exception</exception>
        public static bool ExistsKey( string key )
        {
            if( null == key ) {
                throw new ArgumentNullException( "No se ha indicado clave (" + key + ") en la sesión (FactoryWebSession: Exists)" );
            }
            return null != HttpContext.Current.Session[ key ];
        }


    }
}
