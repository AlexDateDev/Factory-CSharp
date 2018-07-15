using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Strings
{
	public partial class HelperString
	{

		private string ReplaceAccents( string str )
		{
			string texto = str;
			string consignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜ";//ÑçÇ";
			string sinsignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUU";//NcC";
			for( int v = 0; v < sinsignos.Length; v++ ) {
				string i = consignos.Substring( v, 1 );
				string j = sinsignos.Substring( v, 1 );
				texto = texto.Replace( i, j );
			}
			return texto;
		}

	}
}
