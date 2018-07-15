//// ----------------------------------------------------------------------------
//// Título:    Comprobar correo RCPT
////
//// Fecha:     22/06/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


///// <summary>
///// Envia comandos RPCT a un servidor de correo
///// </summary>
///// <param name="email"></param>
//protected void MX( string email )
//{
//    TcpClient tClient = new TcpClient( "mail.caldiable.cat", 25 );
//    string CRLF = "\r\n";
//    byte[ ] dataBuffer;
//    string ResponseString;
//    NetworkStream netStream = tClient.GetStream( );
//    StreamReader reader = new StreamReader( netStream );
//    ResponseString = reader.ReadLine( );
//    /* Perform HELO to SMTP Server and get Response */
//    dataBuffer = BytesFromString( "HELO " + email + CRLF );
//    netStream.Write( dataBuffer, 0, dataBuffer.Length );
//    ResponseString = reader.ReadLine( );
//    dataBuffer = BytesFromString( "MAIL FROM:<"+email+">" + CRLF );
//    netStream.Write( dataBuffer, 0, dataBuffer.Length );
//    ResponseString = reader.ReadLine( );
//    /* Read Response of the RCPT TO Message to know from google if it exist or not */
//    dataBuffer = BytesFromString( "RCPT TO:<" + email + ">" + CRLF );
//    netStream.Write( dataBuffer, 0, dataBuffer.Length );
//    ResponseString = reader.ReadLine( );
//    if( GetResponseCode( ResponseString ) == 550 ) {
//        System.Console.Write( "Mai Address Does not Exist !<br/><br/>" );
//        System.Console.Write( "<B><font color='red'>Original Error from Smtp Server :</font></b>" + ResponseString );
//    }
//    /* QUITE CONNECTION */
//    dataBuffer = BytesFromString( "QUITE" + CRLF );
//    netStream.Write( dataBuffer, 0, dataBuffer.Length );
//    tClient.Close( );
//}
//private byte[ ] BytesFromString( string str )
//{
//    return Encoding.ASCII.GetBytes( str );
//}
//private int GetResponseCode( string ResponseString )
//{
//    return int.Parse( ResponseString.Substring( 0, 3 ) );
//}
