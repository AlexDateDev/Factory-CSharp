using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils.Strings
{
	public partial class HelperString
	{
		/// <summary>
		/// Devuelve un DateTime del string pasado o null si no es una fecha válida.
		/// Si el string no tiene hora (00:00:00) el datetime devuelto vale "00:00:00"
		/// Si no es una fecha u hora válida exception
		/// </summary>
		/// <param fileName="date">String</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>DateTime</returns>
		public static DateTime ToDateTime( string date )
		{

			System.DateTime dt;
			if( System.DateTime.TryParse( date, out dt ) ) {
				return dt;
			}
			throw new ArgumentOutOfRangeException( "No se puede convertir un string a DateTime (String ToDateTime)" );
		}

		internal static short ToShort( string v )
		{
			throw new NotImplementedException( );
		}
	}
}
