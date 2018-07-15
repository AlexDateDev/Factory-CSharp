// ----------------------------------------------------------------------------
// Título:    Read Write Language Cookie
//
// Fecha:     02/01/2015
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;
using System.Globalization;
using System.Threading;

namespace Utils.Cookies
{
    class ProgramDemo2
    {
        public void Main( )
        {

            HttpCookie myCookie = new HttpCookie( "cookIuritexLang" );
            //myCookie = Request.Cookies[ "cookIuritexLang" ];

            //// Read the cookie information and display it.
            if( myCookie != null ) {

                CultureInfo culture = Thread.CurrentThread.CurrentCulture;

                //Context.Session[ "Idioma" ] = "es-ES";

                CultureInfo  cultureCook = new System.Globalization.CultureInfo( "es-ES" );//myCookie.Value ); // you may need to interpret the value of "lang" to match what is expected by CultureInfo
                Thread.CurrentThread.CurrentCulture = cultureCook;
                Thread.CurrentThread.CurrentUICulture = cultureCook;

            } else {
                // Cookie no existe => Miro el que tengo y lo guardo
                CultureInfo culture = Thread.CurrentThread.CurrentCulture;

                HttpCookie myCookieWrite = new HttpCookie( "cookIuritexLang" );
                myCookieWrite.Value = culture.Name;
                myCookieWrite.Expires = DateTime.Now.AddMonths( 6 );
                //Response.Cookies.Add( myCookieWrite );
            }
        }
    }
}
