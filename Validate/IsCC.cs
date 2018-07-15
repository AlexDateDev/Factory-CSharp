// ----------------------------------------------------------------------------
// T�tulo:    IsCC
//
// Fecha:     01/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils.Validates
{
    public partial class FactoryValidate
    {

        /// <summary>
        /// Comprobación de número de cuenta corriente (20 dígitos)
        /// </summary>
        /// <param name="nMonthOrder"></param>
        /// <returns></returns>
        public static bool isCCC( string sCCC )
        {
            if( sCCC.Length != 20 ) {
                return false;
            }
            return true;
        }


        public static bool isCCC( string sBank, string sSucursal, string sDC, string sAccount )
        {
            string sCCC = "";
            if( null != sBank ) { sCCC += sBank; }
            if( null != sSucursal ) { sCCC += sSucursal; }
            if( null != sDC ) { sCCC += sDC; }
            if( null != sAccount ) { sCCC += sAccount; }

            if( sCCC.Length != 20 ) {
                return false;
            }
            return true;
        }
    }
}
