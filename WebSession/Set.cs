using Help.Validates;
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
		/// Guarda una variable en la session
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <exception cref="ex">Exception</exception>
		public static void Set<T>( string key, T value )
		{
			if( HelperValidate.IsEmpty(key) ) {
				throw new ArgumentNullException( "No se ha indicado clave (" + key + ") en la sesión (FactoryWebSession: Set)" );
			}
			if( null == value ) { 
				// El valor puede ser ""
				throw new ArgumentNullException( "No se puede guardar un valor null en la sesion: (" + key + ") (FactoryWebSession: Set)" );
			}
			if( null == HttpContext.Current || null == HttpContext.Current.Session  ) {
				throw new Exception( "No existe HttpContext (FactoryWebSession: Set)" );
			}
			HttpContext.Current.Session.Add( key, value );
		}

	}
}
