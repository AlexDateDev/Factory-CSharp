using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{
		/// <summary>
		///  Devuelve una fecha con el time 0:00:00 a la fecha
		/// </summary>
		/// <param fileName="dt">DatTime</param>
		/// <returns>DateTime</returns>
		public static DateTime SetTimeBegin( DateTime dt )
		{
			return new DateTime( dt.Year, dt.Month, dt.Day, 0, 0, 0 );
		}

	}
}
