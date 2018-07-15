// ----------------------------------------------------------------------------
// IsDNI
//
// Comprueva si es un NIF, NIE o CIF
//
// Date : 01/03/2013
// By   : Alex
// ----------------------------------------------------------------------------

namespace Help.ValidatesDni
{

	public partial class HelperValidateDNI
	{
		/// <summary>
		/// Comprueva si es un NIF, NIE o CIF
		/// </summary>
		/// <param name="sDNI"></param>
		/// <returns></returns>
		public static bool IsDNI( string sDNI )
		{
			NumberDNI num = new NumberDNI( sDNI );
			return num.IsValid;
		}
	}
}