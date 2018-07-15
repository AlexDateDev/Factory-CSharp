using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{ 
		/// <summary>
		/// Devuelve el primer dia de un mes y un año o null si es un mes no válido
		/// El año 0 equivale al 2000.
		/// El año 250 equivale al 0250.
		/// </summary>
		/// <param fileName="Month">int</param>
		/// <param fileName="Year">int</param>
		/// <exception cref="ex"></exception>
		/// <returns>DateTime?</returns>
	public static DateTime GetPrimerDiaMes( int Month, int Year )
		{
			string sdt = "01/" + Month + "/" + Year;
			DateTime dt;
			if( System.DateTime.TryParse( sdt, out dt ) ) {
				return dt;
			}
			throw new ArgumentOutOfRangeException( "El mes y/o el año estan fuera de rango (GetPrimerDiaMes)" );
		}

		/// <summary>
		/// Devuelve el priemr dia del mes al que pertenece la fecha pasada como parámetro
		/// </summary>
		/// <param fileName="dt">DateTime</param>
		/// <returns>DateTime</returns>
		public static DateTime GetPrimerDiaMes( DateTime dt )
		{
			return Convert.ToDateTime( "01/" + dt.Month + "/" + dt.Year );
		}
	}
}
