using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Hosting;
using System.Web;

namespace Help.WebRedirects
{
	public partial class HelperWebRedirect
	{
		/// <summary>
		/// Redirecciona a un URL.
		/// Si EndResponse=true la petición actual termina antes de redireccionar
		/// Si Safe = true, omite todos lo seventos y ejecuta EndRquest directamente
		/// </summary>
		/// <param name="url"></param>
		/// <param name="EndResponse"></param>
		/// <param name="safe"></param>
		public static void GoToPage( string url, bool EndResponse = false, bool safe = false )
		{
			System.Web.UI.Page p = ( System.Web.UI.Page ) HttpContext.Current.Handler;
			p.Response.Redirect( url, EndResponse );
			if( safe ) {
				HttpContext.Current.ApplicationInstance.CompleteRequest( );
			}
		}

	}
}
