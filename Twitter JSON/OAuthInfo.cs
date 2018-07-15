// ----------------------------------------------------------------------------
// T�tulo:    OAuthInfo
//
// Fecha:     27/03/2013
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atexsa.Factory.Twitter {

    /// <summary>
    /// Credenciales de autenticción. Modelo OAuth
    /// </summary>
    public class OAuthenticationInfo {

        public string ConsumerKey {get;set;}
        public string ConsumerSecret {get;set;}
        public string AccessToken {get;set;}
        public string AccessSecret {get;set;}
    }

}
