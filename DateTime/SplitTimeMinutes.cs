using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{
		/// <summary>
		/// Convierte una hora "HH:MM" en dos entereos hora y minutos.
		/// </summary>
		/// <param fileName="sTimeMMHH">string</param>
		/// <param fileName="nHour">out int?</param>
		/// <param fileName="nMinutes">out int?</param>
		/// <exception cref="ex"></exception>
		public static void SplitTimeMinutes( string sTimeMMHH, out int? nHour, out int? nMinutes )
		{
			nHour = null;
			nMinutes = null;
			if( null == sTimeMMHH ) {
				throw new ArgumentNullException( "No se ha indicado la hora (DateTime: SplitTimeMinutes)" );
			}

			string[] aBegin = sTimeMMHH.Split( ':' );
			if( aBegin.Length != 2 ) {
				throw new ArgumentNullException( "Faltan valores de tiempo (hh:mm) (DateTime: SplitTimeMinutes)" );
			}
			string sBeginH = aBegin[ 0 ].Trim( );
			string sBeginM = aBegin[ 1 ].Trim( );

			int i =0;
			if( Int32.TryParse( sBeginH, out i ) && ( i >= 0 && i <= 23 ) ) {
				nHour = i;
			} else {
				throw new ArgumentOutOfRangeException( "Hora fuera de rango (DateTime: SplitTimeMinutes)" );
			}

			if( Int32.TryParse( sBeginM, out i ) && ( i >= 0 && i <= 59 ) ) {
				nMinutes = i;
			} else {
				throw new ArgumentOutOfRangeException( "Mnutos fuera de rango (DateTime: SplitTimeMinutes)" );
			}
		}
  


	}
}
