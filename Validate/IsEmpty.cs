using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Help.Validates
{
	public partial class HelperValidate
	{
		/// <summary>
		/// Indica su un string esta vació (null o espacios en blanco) o tiene algún valor
		/// </summary>
		/// <param name="txt"></param>
		/// <returns></returns>
		public static bool IsEmpty( string txt)
		{
			return string.IsNullOrWhiteSpace( txt );
		}

		/// <summary>
		/// Indica si un DateTime? esta vacio o tiene la fecha 01/01/000 00:00:00 (Fecha vacia)
		/// </summary>
		/// <param fileName="dt">DateTime?: valor a comprobar</param>
		/// <returns>bool: true si no hay fecha o false si hay alguna fecha</returns>
		public static bool IsEmpty( System.DateTime? dt )
		{
			if( null == dt ) {
				return true;
			}
			return dt.Value == new DateTime( );
		}

		/// <summary>
		/// Indica si un DateTime esta vacio o tiene la fecha 01/01/000 00:00:00 (Fecha vacia)
		/// </summary>
		/// <param fileName="dt"></param>
		/// <returns></returns>
		public static bool IsEmpty( System.DateTime dt )
		{
			return dt == new DateTime( );
		}
	}
}
