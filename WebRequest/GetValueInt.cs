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
		/// Devuelve un valor int? por su clave en la request de la pÃ¡gina. Si no existe el valor devuelve null.
		/// </summary>
		/// <param name="key">string</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>int?</returns>
		public static int GetValueInt( string key )
		{
			if( null == key ) {
				throw new ArgumentNullException( "No se ha indicado clave en el request (FactoryWebRequest: GetValueInt)" );
			}
			System.Web.UI.Page p = ( System.Web.UI.Page ) HttpContext.Current.Handler;
			if( p.Request.Params[ key ] == null ) {
				throw new Exception( "No existe clave (" + key + ") en el request (FactoryWebRequest: GetValueInt)" );
			}
			string value = p.Request.Params[ key ];
			if( null == value  ) {
				throw new Exception( "El valor de la clave (" + key + ") esta vacio y no se puede convertir en integer (FactoryWebRequest: GetValueInt)" );
			}

			int i =0;
			if( Int32.TryParse( value, out i ) ) {
				throw new ArgumentOutOfRangeException( "El valor de la clave (" + key + ") no se puede convertir en integer (FactoryWebRequest: GetValueInt)" );
			}
			return i;
		}
	}
}
