using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace Help.WebSessions
{
	public partial class HelperWebSession
	{
		/// <summary>
		/// Termina la session, elimina Cookies y autenticación form. No se redirecciona a otra página
		/// </summary>
		public static void End( )
		{
			if( null != HttpContext.Current && null != HttpContext.Current.Session ) {
				HttpContext.Current.Session.Clear( );
				HttpContext.Current.Session.Abandon( );
				HttpContext.Current.User = null;
				HttpContext.Current.Response.Cookies.Add( new HttpCookie( FormsAuthentication.FormsCookieName, "" ) );
				System.Web.Security.FormsAuthentication.SignOut( ); // if forms auth is used
			}
		}

	}
}
