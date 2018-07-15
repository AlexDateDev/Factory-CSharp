//// ----------------------------------------------------------------------------
//// Título:    Set Get Cookies
////
//// Fecha:     19/01/2015
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

///// <summary>
///// Guarda una cookie de nombre nameCookie guardando una clave/valor
///// </summary>
///// <param nameCookie="nameCookie"></param>
///// <param nameCookie="key"></param>
///// <param nameCookie="value"></param>
//public void SetCookie( string nameCookie,string key,  string value )
//{
//    HttpCookie myCookie = Request.Cookies[ nameCookie] ?? new HttpCookie( nameCookie  );
//    myCookie.Values[ key] = value;
//    myCookie.Expires = DateTime.Now.AddMonths( 1 );
//    Response.Cookies.Add( myCookie );
//}

///// <summary>
///// Devuelve el valor de una Cookie para una clave. Null si no existe
///// </summary>
///// <param name="nameCookie"></param>
///// <param name="key"></param>
///// <returns></returns>
//public string GetCookie( string nameCookie, string key )
//    {
//    HttpCookie myCookie = HttpContext.Current.Request.Cookies[ nameCookie ];
//    if( myCookie != null && null != myCookie.Values[ key ] ) {
//        return myCookie.Values[ key ].ToString( );
//    }
//    return null;
//}

