using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{

		/// <summary>
		/// Calcula los años en función del dia de nacimiento
		/// </summary>
		/// <param fileName="dtBirth">DateTime</param>
		/// <param fileName="dtNow">DateTime</param>
		/// <returns>int</returns>
		public static int CalculateYearsOldBirth( DateTime dtBirth, DateTime dtNow )
		{
			// Calcular la edad
			int nYearActual = dtNow.Year;
			int nYearBirth = dtBirth.Year;
			int nYears = nYearActual - nYearBirth;

			int nMonthActual = dtNow.Month;
			int nDayActual = dtNow.Day;

			int nMonthBirth = dtBirth.Month;
			int nDayBirth = dtBirth.Day;

			if( nMonthBirth > nMonthActual ) {
				nYears -= 1;
			} else if( nMonthBirth == nMonthActual ) {
				if( nDayBirth > nDayActual ) {
					nYears -= 1;
				}
			}
			return nYears;
		}

	}
}
