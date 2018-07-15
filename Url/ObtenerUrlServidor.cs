//// ----------------------------------------------------------------------------
//// Título:    ObtenerUrlServidor
////
//// Fecha:     21/04/2015
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


///// <summary>
///// Devuelve la Url del servidor. Poner en BaseController
///// </summary>
///// <returns></returns>
//private string ObtenerUrlServidor( )
//{
//    string host = HttpContext.Request.Url.Host;
//    string scheme = Request.Url.Scheme;
//    int portServer = Request.Url.Port;
//    string port = string.Empty;
//    if( portServer != 0 && portServer != 80 && portServer != 443 ) {
//         port = ":" + portServer;
//    }

//    StringBuilder url = new StringBuilder( scheme );
//    url.Append( "://" ).Append( host ).Append( port );
//    return url.ToString( );
//}
