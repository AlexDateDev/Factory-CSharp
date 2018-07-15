using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{

		/// <summary>
		/// Compara dos fechas.
		/// 0 = son iguales.
		/// 1 = dt1 mayor que dt2.
		/// -1 = dt1 menor que dt2.
		/// </summary>
		/// <param fileName="dtIni">DateTime</param>
		/// <param fileName="dtEnd">DateTime</param>
		/// <returns>int</returns>
		public static int CompareTo( DateTime dt1, DateTime dt2 )
		{
			return dt1.CompareTo( dt2 );
		}  

	}
}
