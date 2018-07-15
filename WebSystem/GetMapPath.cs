using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Hosting;

namespace Help.WebSystems
{
	public partial class HelperWebSystem
	{
		/// <summary>
		/// Devuelve la ruta completa del path del site Web
		/// Sólo aplicable a sitios Web
		/// </summary>
		/// <param name="fileDir"></param>
		/// <returns></returns>
		public static string GetMapPath( string fileDir )
		{
			if( fileDir.Substring( 0, 1 ) != "~" ) {
				fileDir = "~" + fileDir;
			}
			return HostingEnvironment.MapPath( "~/Administracion/LogsErrores/LogNews" );
            
		}


	}
}
