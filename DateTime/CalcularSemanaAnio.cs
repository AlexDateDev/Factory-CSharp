using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{
		/// <summary>
		/// Saber la semana del año
		/// </summary>
		/// <param fileName="dt"></param>
		/// <returns></returns>
		public static int CalcularSemanaAnio( DateTime dt )
		{
			return System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear( dt, CalendarWeekRule.FirstDay, dt.DayOfWeek );
		}

	}
}
