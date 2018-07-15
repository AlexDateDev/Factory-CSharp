using System.Diagnostics;
using System.Net.NetworkInformation;
using System;

namespace Help.Systems
{

	public partial class HelperString
	{
		/// <summary>
		/// Devuelve la MAC de la tarjeta de red del ordenador acgual
		/// </summary>
		/// <returns></returns>
		/// <exception cref="ex">Exception</exception>
		public static string GetMACAddress( )
		{
			try {
				NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces( );
				string sMacAddress = null;
				foreach( NetworkInterface adapter in nics ) {
					if( null == sMacAddress ) {	// only return MAC Address from first card          
						IPInterfaceProperties properties = adapter.GetIPProperties( );
						sMacAddress = adapter.GetPhysicalAddress( ).ToString( );
					}
				} return sMacAddress;
			} catch( Exception ex ) {
				//doing nothing
				throw new Exception( "Imposible obtener la MAC: " + ex.Message, ex );
			}
		}


	}
}