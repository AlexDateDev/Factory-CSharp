using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration; // Add Reference

namespace Help.WebConfigs
{
	public partial class HelperWebConfig
	{
		/// <summary>
		/// Devuelve el valor string de parámetro del FactoryWebConfig
		/// </summary>
		/// <param name="strParam"></param>
		/// <returns></returns>
		public static T Get<T>( string strParam )
		{
			try {
				object ret = ConfigurationManager.AppSettings[ strParam ];
				if( null == ret ) {
					throw new Exception( "No existe el valor " + strParam + " en el FactoryWebConfig" );
				}
				return ( T ) ret;
			} catch( Exception ex ) {
				System.Console.WriteLine( ex.Message );
				return default( T );
			}
		}

	}
}
