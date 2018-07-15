//// ----------------------------------------------------------------------------
//// Título:    Manipular campos por su nombre como string
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//public class LanguageUtils
//{
//    /// <summary>
//    /// Set value , por idioma en la Table
//    /// </summary>
//    /// <param name="st"></param>
//    /// <param name="Description"></param>
//    /// <param name="idiomaKey"></param>
//    /// <returns></returns>
//    public static void InsertTraslateString(StringTable st, string Description, string idiomaKey)
//    {
//        if (idiomaKey == "caES") idiomaKey = "caCA";
//        PropertyInfo pi = st.GetType().GetProperties().FirstOrDefault(p => p.Name == "String_" + idiomaKey);
//        if (pi != null)
//        {
//            pi.SetValue(st, Description, null);
//        }
//    }
//    public static void InsertTraslateImage(Image im, string Description, string idiomaKey)
//    {
//        if (idiomaKey == "caES") idiomaKey = "caCA";
//        PropertyInfo pi = im.GetType().GetProperties().FirstOrDefault(p => p.Name == "Image_" + idiomaKey);
//        if (pi != null)
//        {
//            pi.SetValue(im, Description, null);
//        }
//    }

//    /// <summary>
//    /// Get value, de las stringTable por idioma
//    /// </summary>
//    /// <param name="st"></param>
//    /// <param name="idiomaKey"></param>
//    /// <returns></returns>
//    public static string TranslateStringSession(StringTable st, string idiomaKey)
//    {
//        if (idiomaKey != null)
//        {
//            idiomaKey = idiomaKey.Split('-')[0] + idiomaKey.Split('-')[1];
//        }
//        if (idiomaKey == "caES") idiomaKey = "caCA";
//        string result = string.Empty;

//        if (st != null)
//        {
//            if (idiomaKey == string.Empty)
//            {
//                idiomaKey = "esES"; //Language defecto
//            }

//            PropertyInfo pi = st.GetType().GetProperties().FirstOrDefault(p => p.Name == "String_" + idiomaKey);
//            if (pi != null)
//            {
//                object val = pi.GetValue(st, null);
//                if (val != null)
//                {
//                    result = val.ToString();
//                }
//            }
//        }
//        return result;
//    }

//    /// <summary>
//    /// Get value, de las stringTable por idioma
//    /// </summary>
//    /// <param name="st"></param>
//    /// <param name="idiomaKey"></param>
//    /// <returns></returns>
//    public static string TranslateString(StringTable st, string idiomaKey)
//    {
//        if (idiomaKey == "caES") idiomaKey = "caCA";
//        string result = string.Empty;

//        if (st != null)
//        {
//            if (idiomaKey == string.Empty)
//            {
//                idiomaKey = "esES"; //Language defecto
//            }

//            PropertyInfo pi = st.GetType().GetProperties().FirstOrDefault(p => p.Name == "String_" + idiomaKey);
//            if (pi != null)
//            {
//                object val = pi.GetValue(st, null);
//                if (val != null)
//                {
//                    result = val.ToString();
//                }
//            }
//        }
//        return result;
//    }

//    public static string TranslateImage(Image st, string idiomaKey)
//    {
//        if (idiomaKey == "caES") idiomaKey = "caCA";
//        string result = string.Empty;

//        if (st != null)
//        {
//            if (idiomaKey == string.Empty)
//            {
//                idiomaKey = "esES"; //Language defecto
//            }
//            PropertyInfo pi;
//            if (st.Common)
//            {
//                pi = st.GetType().GetProperties().FirstOrDefault(p => p.Name == "ImageCommon");
//            }
//            else
//            {
//                pi = st.GetType().GetProperties().FirstOrDefault(p => p.Name == "Image_" + idiomaKey);
//            }
//            if (pi != null)
//            {
//                object val = pi.GetValue(st, null);
//                if (val != null)
//                {
//                    result = val.ToString();
//                }
//            }

//        }
//        return result;
//    }
//}
