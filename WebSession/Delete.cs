using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Help.WebSessions
{
	public partial class HelperWebSession
	{
		/// <summary>
		/// Elimina una variable guardada en la session.
		/// </summary>
		/// <exception cref="ex"></exception>
		/// <param name="key"></param>
		public static void Delete( string key )
		{
			if( null == key  ) {
				throw new ArgumentNullException( "No se ha indicado clave (" + key + ") en la sesión (FactoryWebSession: Clear)" );
			}
			HttpContext.Current.Session.Remove( key );
		}

	}
}
