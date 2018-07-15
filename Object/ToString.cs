using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Objects
{
	public partial class HelperObject
	{

		/// <summary>
		/// Convierte unobjeto a un String.
		/// Si el objeto no se puede convertir, devuelve Empty
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static string ToString( object obj )
		{
			if( null == obj || !( obj is string ) ) {
				return string.Empty;
			} else {
				return ( string ) obj;
			}
		}

	}
}
