using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Numbers
{
	public partial class HelperNumber
	{

		public static string ToString( float fValue, System.Globalization.CultureInfo ci = null )
		{
			if( null == ci ) {
				ci = new System.Globalization.CultureInfo( "es-es" );
			}
			return fValue.ToString( ci );
			//float num = 1.5f;
			//string str = num.ToString( CultureInfo.InvariantCulture.NumberFormat );        // "1.5"
			//string str = num.ToString( CultureInfo.GetCultureInfo( "de-DE" ).NumberFormat ); // "1,5"
		}

	}
}
