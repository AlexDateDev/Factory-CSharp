using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Numbers
{
	public partial class HelperNumber
	{

		/// <summary>
		/// Devuelve un array de bytes
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		private static byte[ ] ToByteArray( int val )
		{
			return System.BitConverter.GetBytes( val );
		}


	}
}
