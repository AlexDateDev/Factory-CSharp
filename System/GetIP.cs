using System.Diagnostics;

namespace Help.Systems
{

	public partial class HelperString
	{
		/// <summary>
		/// Devuelve la IP
		/// </summary>
		/// <returns></returns>
		public static string GetIP( )
		{
			return System.Net.Dns.GetHostEntry( System.Net.Dns.GetHostName( ) ).AddressList.GetValue( 0 ).ToString( );
		}


	}
}