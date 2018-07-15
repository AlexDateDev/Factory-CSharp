using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Web;

namespace Help.Auths
{
    public partial class HelperAuth
    {
        public static void CreateAuthenticationCookieSingle( string usuario )
        {
            HttpContext http = System.Web.HttpContext.Current;
            if( null != http ) {
                int CookVers = 1;
                string CookName = usuario;
                DateTime CookIssueDate = DateTime.Now;
                DateTime CookExpiration = DateTime.Now.AddMinutes( http.Session.Timeout );
                bool CookIsPersistemt = false;
                String CookUserData = "UserData";
                String CookPath = FormsAuthentication.FormsCookiePath;

                var ticket = new FormsAuthenticationTicket( CookVers, CookName, CookIssueDate, CookExpiration, CookIsPersistemt, CookUserData, CookPath );

                var encryptedTicket = FormsAuthentication.Encrypt( ticket );
                var cookie = new HttpCookie( FormsAuthentication.FormsCookieName, encryptedTicket );

                http.Response.Cookies.Add( cookie );
            }
        }
    }
}
