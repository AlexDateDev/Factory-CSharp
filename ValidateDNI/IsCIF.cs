// ----------------------------------------------------------------------------
// IsCIF
//
// Comprueva si es un CIF
//
// Date : 01/03/2013
// By   : Alex
// ----------------------------------------------------------------------------

namespace Help.ValidatesDni{

	public partial class HelperValidateDNI
	{
		/// <summary>
		/// Comprueva si es un CIF
		/// </summary>
		/// <param name="sDNI"></param>
		/// <returns></returns>
		public static bool IsCIF( string sCIF )
		{
			NumberDNI num = new NumberDNI( sCIF );
			return ( num.IsValid && num.TypeDNI == "CIF" );
		}
	}
}