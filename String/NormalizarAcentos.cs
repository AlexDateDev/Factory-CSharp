//// ----------------------------------------------------------------------------
//// T�tulo:    NormalizarAcentos
////
//// Fecha:     26/01/2015
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

// /// <summary>
//    /// Funcion que permite suprimir los acentos de una cadena. Se utiliza para el mapeo de las urls, ya que la url no permite acentso
//    /// </summary>
//    /// <param name="inputString"></param>
//    /// <returns></returns>
//    public static string RemoveAccentsWithNormalization(string inputString)
//    {
//        string normalizedString = inputString.Normalize(NormalizationForm.FormD);
//        StringBuilder sb = new StringBuilder();
//        for (int i = 0; i < normalizedString.Length; i++)
//        {
//            UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(normalizedString[i]);
//            if (uc != UnicodeCategory.NonSpacingMark)
//            {
//                sb.Append(normalizedString[i]);
//            }
//        }
//        return (sb.ToString().Normalize(NormalizationForm.FormC));
//    }


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Utils.Strings
//{
//    public partial class FactoryString
//    {

//        private string ReplaceAccents( string str )
//        {
//            string texto = str;
//            string consignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜ";//ÑçÇ";
//            string sinsignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUU";//NcC";
//            for( int v = 0; v < sinsignos.Length; v++ ) {
//                string i = consignos.Substring( v, 1 );
//                string j = sinsignos.Substring( v, 1 );
//                texto = texto.Replace( i, j );
//            }
//            return texto;
//        }

//    }
//}
