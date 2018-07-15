using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Utils.Strings;

namespace Help.WebSessions
{
	public partial class HelperWebSession
	{
		/// <summary>
		/// Devuelve un valor de una variable guardada en la sesión
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="ex">Exception</exception>
		public static T Get<T>( string key )
		{
			if( string.IsNullOrWhiteSpace( key )) {
				throw new ArgumentNullException( "No se ha indicado clave (" + key + ") en la sesión (FactoryWebSession: Get)" );
			}

			if( null == HttpContext.Current || null == HttpContext.Current.Session  ) {
				throw new Exception( "No existe HttpContext (FactoryWebSession: Get)" );
			}
			if( null == HttpContext.Current.Session[ key ] ) {
				throw new Exception( "No existe clave (" + key + ") en la sesión (FactoryWebSession: Get)" );
			}
			object ret = HttpContext.Current.Session[ key ];
			return ( T ) ret;
		}
	}
}
