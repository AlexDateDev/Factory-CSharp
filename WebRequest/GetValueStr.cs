using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Hosting;
using System.Web;

namespace Help.WebRequests
{
	public partial class HelperWebRequest
	{
		/// <summary>
		/// Devuelve un valor por su clave en la request de la pÃ¡gina. Si no existe el valor devuelve null.
		/// </summary>
		/// <param name="key">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>string/returns>
		public static string GetValueStr( string key )
		{
			if( null == key ) {
				throw new ArgumentNullException( "No se ha indicado clave en el request (FactoryWebRequest: GetValueStr)" );
			}
			System.Web.UI.Page p = ( System.Web.UI.Page ) HttpContext.Current.Handler;
			if( null == p.Request.Params[ key ]  ) {
				throw new Exception( "No existe clave (" + key + ") en el request (FactoryWebRequest: GetValueStr)" );
			}
			return p.Request.Params[ key ];
		}


	}
}
