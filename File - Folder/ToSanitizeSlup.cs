//// ----------------------------------------------------------------------------
//// T�tulo:    ToSanitizeSlup
////
//// Fecha:     22/06/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------


///*
//�     Devuelve un nombre de archivo, sin acentos, espacions ni nada extra�o
//� */
//protected string ToSanitizeSlug( string value )
//{
//    //First to lower case
//    value = value.ToLowerInvariant( );

//    //Remove all accents
//    var bytes = Encoding.GetEncoding( "Cyrillic" ).GetBytes( value );
//    value = Encoding.ASCII.GetString( bytes );

//    //Replace spaces
//    value = Regex.Replace( value, @"\s", "-", RegexOptions.Compiled );

//    //Remove invalid chars
//    value = Regex.Replace( value, @"[^a-z0-9\s-_.]", "", RegexOptions.Compiled );

//    //Trim dashes from end
//    value = value.Trim( '-', '_' );

//    //Replace double occurences of - or _
//    value = Regex.Replace( value, @"([-_]){2,}", "$1", RegexOptions.Compiled );

//    return value;
//}
