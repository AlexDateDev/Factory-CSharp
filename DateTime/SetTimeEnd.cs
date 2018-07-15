using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{
		/// <summary>
		///  Devuelve una fecha con el time 23:59:59 a la fecha
		/// </summary>
		/// <param fileName="dt"></param>
		/// <returns>DateTime</returns>
		public static DateTime SetTimeEnd( DateTime dt )
		{
			return new DateTime( dt.Year, dt.Month, dt.Day, 23, 59, 59 );
		}

	}
}
