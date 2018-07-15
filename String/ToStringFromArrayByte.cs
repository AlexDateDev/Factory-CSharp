///// <summary>
///// Convierte un array de bytes en un string
///// </summary>
///// <param name="data"></param>
///// <exception cref="ex"></exception>
///// <returns></returns>
//public static string ToStringFromArrayByte( byte[ ] data )
//{
//    if (null == data ){
//        throw new ArgumentNullException( "No se ha indicado array de bytes (Factory.Core.String: ToStringFromArrayByte)" );
//    }
//    try {
//        return Encoding.UTF8.GetString( data, 0, data.Length );

//    } catch( Exception ex ) {
//        throw new Exception( "Imposible convertir una rray de bytes a unstring (Factory.Core.String: ToStringFromArrayByte)", ex );
//    }
//}