using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{

		/// <summary>
		/// Genera un string aleatorio de N chars
		/// </summary>
		/// <param fileName="numChars"></param>
		/// <returns></returns>
		public static string GenerateRandom( int numChars )
		{
			StringBuilder StrBuilder = new StringBuilder( numChars );
			Random RandomNum = new Random( ( int ) DateTime.Now.Ticks );

			for( int i = 0; i < numChars; i++ ) {
				StrBuilder.Append( Convert.ToChar( Convert.ToInt32( Math.Floor( 26 * RandomNum.NextDouble( ) + 65 ) ) ));
			}
			return StrBuilder.ToString( );
		}

		/*
		public string buildRandomString( int StringLength = 10 )
		{
			char[] myChars = new char[ StringLength ];
			Random rnd = new Random( );
			for( int i = 0; i < StringLength; i++ ) {
				myChars[ i ] = ( char ) ( rnd.Next( 97, 123 ) );
			}
			string Randomtring = new String( myChars );
			return Randomtring;
		}
		*/

	}
}
