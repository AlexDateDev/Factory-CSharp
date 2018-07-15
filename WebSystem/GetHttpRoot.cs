using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Hosting;
using System.Web;

namespace Help.WebSystems
{
	public partial class HelperWebSystem
	{

		// Devuelve la ruta http de donde se ejecuta la aplicación

		private string GetHttpRoot( )
		{
			string host = ( HttpContext.Current.Request.Url.IsDefaultPort ) ?
				HttpContext.Current.Request.Url.Host :
				HttpContext.Current.Request.Url.Authority;
			host = String.Format( "{0}://{1}", HttpContext.Current.Request.Url.Scheme, host );
			if( HttpContext.Current.Request.ApplicationPath == "/" )
				return host;
			else
				return host + HttpContext.Current.Request.ApplicationPath;
		}
	}
}
