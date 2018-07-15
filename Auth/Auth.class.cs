using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

/*
 * Application:    Auth
 * Date:        22-07-2013
 * *************************************/

namespace Help.Auths
{
    /// <summary>
    /// Auth
    /// </summary>
    public partial class HelperAuth
    {
        private HttpContext _http;

        /// <summary>
        /// Auth
        /// </summary>
        public HelperAuth(  HttpContext http = null )
        {
            this._http = http;
        }

        /// <summary>
        /// Crea la cookie de autenticación
        /// </summary>
        /// <param fileName="usuario"></param>
        /// <param fileName="httpContext"></param>
        public void CreateAuthenticationCookie( string nombreUsuario )
        {
            if( null != this._http) {
                var ticket = new FormsAuthenticationTicket(
                    version: 1,
                    name: nombreUsuario,
                    issueDate: DateTime.Now,
                    expiration: DateTime.Now.AddMinutes( this._http.Session.Timeout ),
                    isPersistent: false,
                    userData: "UserData",
                    cookiePath: FormsAuthentication.FormsCookiePath );

                var encryptedTicket = FormsAuthentication.Encrypt( ticket );
                var cookie = new HttpCookie( FormsAuthentication.FormsCookieName, encryptedTicket );

                this._http.Response.Cookies.Add( cookie );
            }
        }
    }
}
