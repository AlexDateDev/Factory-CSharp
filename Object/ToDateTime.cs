using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Objects
{
	public partial class HelperObject
	{

		/// <summary>
		/// Covierte un objeto a un DateTime. Si no lo puede convertir, devuelve null
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static System.DateTime? ToDateTime( object obj )
		{
			try {
				string strDate = obj.ToString( );

				System.DateTime dt;
				if( System.DateTime.TryParse( strDate, out dt ) ) {
					return dt;
				} else {
					return null;
				}
			} catch( Exception ex ) {
				throw ex;
			}
		}

	}
}
