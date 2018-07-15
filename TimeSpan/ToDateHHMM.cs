using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Hosting;

namespace Help.TimeSpans
{
	public partial class HelperTimeSpan
	{
		private string ToDateHHMM( TimeSpan? dt )
		{
			if( null == dt ) {
				return "";
			}
			string sHH = ( "00" + dt.Value.Hours.ToString( ) );
			sHH = sHH.Substring( sHH.Length - 2 );

			string sMM = ( "00" + dt.Value.Minutes.ToString( ) );
			sMM = sMM.Substring( sMM.Length - 2 );
			string sHHMM = sHH + ":" + sMM;
			return sHHMM;
		}


	}
}
