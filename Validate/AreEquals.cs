using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Validates
{
	public partial class HelperValidate
	{
		/// <summary>
		/// Comprueva si dos string son iguales.
		/// La comprobación se realiza sin tener en cuentas las mayúsculas ni acentos
		/// null y "" son diferentes, "" y "" son iguales.
		/// CaseSentive = false => No diferencia entre mayus y minus
		/// CaseSentive = true => SI diferencia entre mayus y minus
		/// </summary>
		/// <param fileName="s1"></param>
		/// <param fileName="s2"></param>
		/// <param fileName="CaseSensitive"></param>
		/// <returns></returns>
		public static bool AreEquals( string s1, string s2, bool CaseSensitive=false )
		{
			// Los dos null => Iguales
			if( null == s1 && null == s2 ) {
				return true;
			}

			// Alguno es null => No iguales
			if( ( null != s1 && null == s2 ) || ( null == s1 && null != s2 ) ) {
				return false;
			}

			bool equals = false;
			if( CaseSensitive ) {
				equals =s1.Equals( s2, StringComparison.InvariantCulture );
			} else {
				equals = s1.Equals( s2, StringComparison.InvariantCultureIgnoreCase );
			}
			return equals;
		}

	}
}
