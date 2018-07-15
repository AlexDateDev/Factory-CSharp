using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Collections
{
	//class ProgramCollections2
	//{
	//    private void Main( string[ ] args )
	//    {
	//        List<string> lst = new List<string>( ){
	//            "1", "2",  "3", "4", "10", "19", "22", "30", "31", "100", "201", "220", "300", "A", "A1", "AB","AD", "A9999", "A1X", "BCD", "C", "CA", "CCC",  "D", "DA", "D9", "DB", "DBC" };


	//        lst.Sort( );
	//        lst.Reverse( );

	//        lst.Sort( new NaturalSortString( ) );
	//        int n = lst.Count( );

	//        lst = new List<string>( ){
	//            "4", "2",  "19", "31","220",  "3", "30",   "201","1",  "300", "A", "AB","AD",  "CCC","C", "CA", "100", "DBC",  "DB",  "D", "DA", "22", "BCD"};

	//        lst.Sort( new NaturalSortString( ) );
	//        n = lst.Count( );

	//    }
	//}

	/// <summary>
	/// Clase de ordenación natural
	/// </summary>
	public class HelperNaturalSortString : IComparer<string>
	{
		/// <summary>
		/// Función de comparas
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare( string x, string y )
		{
			string s1 = x;
			if( s1 == null ) {
				return 0;
			}
			string s2 = y;
			if( s2 == null ) {
				return 0;
			}

			int len1 = s1.Length;
			int len2 = s2.Length;
			int marker1 = 0;
			int marker2 = 0;

			// Walk through two the strings with two markers.
			while( marker1 < len1 && marker2 < len2 ) {
				char ch1 = s1[ marker1 ];
				char ch2 = s2[ marker2 ];

				// Some buffers we can build up characters in for each chunk.
				char[] space1 = new char[ len1 ];
				int loc1 = 0;
				char[] space2 = new char[ len2 ];
				int loc2 = 0;

				// Walk through all following characters that are digits or
				// characters in BOTH strings starting at the appropriate marker.
				// Collect char arrays.
				do {
					space1[ loc1++ ] = ch1;
					marker1++;

					if( marker1 < len1 ) {
						ch1 = s1[ marker1 ];
					} else {
						break;
					}
				} while( char.IsDigit( ch1 ) == char.IsDigit( space1[ 0 ] ) );

				do {
					space2[ loc2++ ] = ch2;
					marker2++;

					if( marker2 < len2 ) {
						ch2 = s2[ marker2 ];
					} else {
						break;
					}
				} while( char.IsDigit( ch2 ) == char.IsDigit( space2[ 0 ] ) );

				// If we have collected numbers, compare them numerically.
				// Otherwise, if we have strings, compare them alphabetically.
				string str1 = new string( space1 );
				string str2 = new string( space2 );

				int result;

				if( char.IsDigit( space1[ 0 ] ) && char.IsDigit( space2[ 0 ] ) ) {
					int thisNumericChunk = int.Parse( str1 );
					int thatNumericChunk = int.Parse( str2 );
					result = thisNumericChunk.CompareTo( thatNumericChunk );
				} else {
					result = str1.CompareTo( str2 );
				}

				if( result != 0 ) {
					return result;
				}
			}
			return len1 - len2;
		}

	}
}
