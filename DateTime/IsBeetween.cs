using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{ 
		/// <summary>
		/// Indica si una fecha esta entr otras dos
		/// </summary>
		/// <param fileName="dtBegin"></param>
		/// <param fileName="dtStart"></param>
		/// <param fileName="dtEnd"></param>
		/// <param fileName="BeginCerrado"></param>
		/// <param fileName="EndCerrado"></param>
		/// <returns></returns>
	public static bool IsBeetween( DateTime dtBegin, DateTime dtStart, DateTime dtEnd, bool BeginCerrado = true, bool EndCerrado = true )
		{
			if( BeginCerrado && EndCerrado ) {
				if( dtBegin >= dtStart && dtBegin <= dtEnd ) {
					return true;
				}
			}
			if( !BeginCerrado && EndCerrado ) {
				if( dtBegin > dtStart && dtBegin <= dtEnd ) {
					return true;
				}
			}
			if( BeginCerrado && !EndCerrado ) {
				if( dtBegin >= dtStart && dtBegin < dtEnd ) {
					return true;
				}
			}
			if( !BeginCerrado && !EndCerrado ) {
				if( dtBegin > dtStart && dtBegin < dtEnd ) {
					return true;
				}
			}
			return false;

		}
	}
}
