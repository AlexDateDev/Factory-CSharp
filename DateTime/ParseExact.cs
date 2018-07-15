using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{

		public static DateTime ParseExact( string dt)
		{
			return  DateTime.ParseExact( dt, "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture ).ToLocalTime( );
		}

	}
}
