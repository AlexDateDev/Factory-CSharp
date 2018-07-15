using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Hosting;
using System.Web;

namespace Utils.WebRequests
{
	public partial class HelperWebRequest
	{
		/// <summary>
		/// Indica si existe un key/value en el request
		/// </summary>
		/// <param name="key">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>bool</returns>
		public static bool Exists( string key )
		{
			if( null == key ) {
				throw new ArgumentNullException( "No se ha indicado clave en el request (FactoryWebRequest: Exists)" );
			}
			System.Web.UI.Page p = ( System.Web.UI.Page ) HttpContext.Current.Handler;
			return null != p.Request.Params[ key ];
		}

	}
}
