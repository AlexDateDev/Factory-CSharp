using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{
		bool IsLeap( int Year ) {
			return DateTime.IsLeapYear(Year);
		}
	}
}
