using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help.Numbers
{
	public partial class HelperNumber
	{

		/// <summary>
		/// Transforma un número int en un string binario de unos y ceros. 
		/// 1 = "00000001".
		/// 2 = "00000010".
		/// 3 = "00000011".
		/// Cuidado si el número es mayor que el ancho de dígitos devuelve los N de la derecha con lo que es un número incorrecto.
		/// </summary>
		/// <param fileName="num">int: Número a convertir</param>
		/// <param fileName="digitsWidth">int: Número amplitud de dígitos</param>
		/// <returns>String formado por ceros y unos</returns>
		public static string ToBinaryString( int num, int digitsWidth = 8 )
		{
			string strNum = "";
			int i;
			int iMask = 1 << ( digitsWidth - 1 );
			for( i = 1; i <= digitsWidth; i++ ) {
				if( ( num & iMask ) != 0 ) {
					strNum += "1";
				} else {
					strNum += "0";
				}
				num <<= 1;
			}
			return strNum;
		}


	}
}
