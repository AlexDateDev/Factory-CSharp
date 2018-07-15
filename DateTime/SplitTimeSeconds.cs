using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.DateTimes
{
	public partial class HelperDateTime
	{
		/// <summary>
		/// Convierte una hora "HH:MM:SS" en dos entereos hora, minutos y segundos.
		/// Cualquier valor que no se puede convertir es null.
		/// </summary>
		/// <param fileName="sTimeMMHH">string</param>
		/// <param fileName="nHour">out int?</param>
		/// <param fileName="nMinutes">out int?</param>
		/// <param fileName="nSeconds">out int?</param>
		/// <exception cref="ex"></exception>
		public static void SplitTimeSeconds( string sTimeMMHH, out int? nHour, out int? nMinutes, out int? nSeconds )
		{
			nHour = null;
			nMinutes = null;
			nSeconds = null;
			if( null == sTimeMMHH ) {
				throw new ArgumentNullException( "No se ha indicado la hora (DateTime: SplitTimeSeconds)" );
			}

			string[] aBegin = sTimeMMHH.Split( ':' );
			if( aBegin.Length != 3 ) {
				throw new ArgumentNullException( "Faltan valores de tiempo (hh:mm:ss) (DateTime: SplitTimeSeconds)" );
			}
			string sBeginH = aBegin[ 0 ].Trim( );
			string sBeginM = aBegin[ 1 ].Trim( );
			string sBeginS = aBegin[ 2 ].Trim( );

			int i =0;
			if( Int32.TryParse( sBeginH, out i ) && ( i >= 0 && i <= 23 ) ) {
				nHour = i;
			} else {
				throw new ArgumentOutOfRangeException( "Hora fuera de rango (DateTime: SplitTimeSeconds)" );
			}

			if( Int32.TryParse( sBeginM, out i ) && ( i >= 0 && i <= 59 ) ) {
				nMinutes = i;
			} else {
				throw new ArgumentOutOfRangeException( "Minutes fuera de rango (DateTime: SplitTimeSeconds)" );
			}

			if( Int32.TryParse( sBeginS, out i ) && ( i >= 0 && i <= 59 ) ) {
				nSeconds = i;
			} else {
				throw new ArgumentOutOfRangeException( "Segundos fuera de rango (DateTime: SplitTimeSeconds)" );
			}
		}


	}
}
