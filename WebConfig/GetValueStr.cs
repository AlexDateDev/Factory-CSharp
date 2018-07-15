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
		/// Devuelve el valor de parámetro del FactoryWebConfig
		/// </summary>
		/// <param name="strParam"></param>
		/// <returns></returns>
		protected static string GetValueStr( string param )
		{
			return ConfigurationManager.AppSettings.Get( param );
		}

	}
}
