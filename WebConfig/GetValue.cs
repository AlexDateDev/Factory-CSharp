// ----------------------------------------------------------------------------
// T�tulo:    GetValue
//
// Fecha:     01/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration; // Add Reference

namespace Utils.WebConfigs
{
    public partial class FactoryWebConfig
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
