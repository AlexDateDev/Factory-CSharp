// ----------------------------------------------------------------------------
// IsNIF
//
// Comprueva si es un NIF
//
// Date : 01/03/2013
// By   : Alex
// ----------------------------------------------------------------------------

namespace Help.ValidatesDni
{

	public  partial class HelperValidateDNI
	{
		/// <summary>
		/// Comprueva si es un NIF
		/// </summary>
		/// <param name="sDNI"></param>
		/// <returns></returns>
		public static bool IsNIF( string sNIF )
		{
			NumberDNI num = new NumberDNI( sNIF );
			return ( num.IsValid && num.TypeDNI == "NIF" );
		}
	}
}