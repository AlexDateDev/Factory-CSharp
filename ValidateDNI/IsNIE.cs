// ----------------------------------------------------------------------------
// IsNIE
//
// Comprueva si es un NIE
//
// Date : 01/03/2013
// By   : Alex
// ----------------------------------------------------------------------------

namespace Help.ValidatesDni
{

	public partial class HelperValidateDNI
	{
		/// <summary>
		/// Comprueva si es un NIE
		/// </summary>
		/// <param name="sDNI"></param>
		/// <returns></returns>
		public static bool IsNIE( string sNIE )
		{
			NumberDNI num = new NumberDNI( sNIE );
			return ( num.IsValid && num.TypeDNI == "NIE" );
		}
	}
}