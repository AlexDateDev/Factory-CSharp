//// ----------------------------------------------------------------------------
//// T�tulo:    RequestBuilder
////
//// Fecha:     27/03/2013
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Net;
//using System.Text;
//using System.Security.Cryptography;
//using System.Text.RegularExpressions;

//namespace Atexsa.Factory.Twitter {

//    /// <summary>
//    /// Implementa la gestión de una petición contra el servidor Tweeter
//    /// </summary>
//    public class RequestBuilder {

//        private const string VERSION = "1.0"; // Versión a utilizar para la autenticación OAuth
//        private const string SIGNATURE_METHOD = "HMAC-SHA1"; // Tipo de encriptación para ls firma

//        private readonly OAuthenticationInfo oauth;
//        private readonly string method;
//        private readonly IDictionary<string, string> customParameters;
//        private readonly string url;

//        /// <summary>
//        /// Constructor
//        /// </summary>
//        /// <param name="oauth"></param>
//        /// <param name="method"></param>
//        /// <param name="url"></param>
//        public RequestBuilder( OAuthenticationInfo oauth, string method, string url ) {
//            this.oauth = oauth;
//            this.method = method;
//            this.url = url;
//            customParameters = new Dictionary<string, string>( );
//        }

//        /// <summary>
//        /// Añadir un parámetro an enviar al servidor
//        /// </summary>
//        /// <param name="name"></param>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public RequestBuilder AddParameter( string name, string value ) {
//            // Los parámetros van eb formato RFC 3986
//            customParameters.Add( name, value.EncodeRFC3986( ) );
//            return this;
//        }

//        /// <summary>
//        /// Ejecuta un request y devuelve un response
//        /// </summary>
//        /// <returns></returns>
//        public WebResponse Execute( ) {
//            var timespan = this.GetTimestamp( ); // Fecha formato Unix timestamp
//            var nonce = this.CreateToken( ); // Token

//            // Pasamos los parámetros de autenticación
//            var parameters = new Dictionary<string, string>( customParameters );
//            this.AddOAuthParameters( parameters, timespan, nonce );

//            // Montamos la forma necesaria para poder acceder al servicio Tweeter
//            var signature = this.GenerateSignature( parameters );
//            var headerValue = this.GenerateAuthorizationHeaderValue( parameters, signature );

//            var request = (HttpWebRequest) WebRequest.Create( this.GetRequestUrl( ) );
//            request.Method = method;
//            request.ContentType = "application/x-www-form-urlencoded";

//            // Añadimos la cabecera al request
//            request.Headers.Add( "Authorization", headerValue );

//            // Enviamos petición
//            this.WriteRequestBody( request );

//            // Devolvemos la respuesta
//            return request.GetResponse( );
//        }


//        /// <summary>
//        /// Enviamos request
//        /// </summary>
//        /// <param name="request"></param>
//        private void WriteRequestBody( HttpWebRequest request ) {
//            if( method == "GET" ) {
//                return;
//            }

//            var requestBody = Encoding.ASCII.GetBytes( this.GetCustomParametersString( ) );

//            using( var stream = request.GetRequestStream( ) ) {
//                stream.Write( requestBody, 0, requestBody.Length );
//            }
//        }

//        /// <summary>
//        /// Montamos la url en función del tipo de petición
//        /// </summary>
//        /// <returns></returns>
//        private string GetRequestUrl( ) {
//            if( method != "GET" || customParameters.Count == 0 )
//                return url;

//            return string.Format( "{0}?{1}", url, this.GetCustomParametersString( ) );
//        }

//        /// <summary>
//        /// Parámetros POST
//        /// </summary>
//        /// <returns></returns>
//        private string GetCustomParametersString( ) {
//            // key1=value1&key2=value2...
//            return customParameters.Select( x => string.Format( "{0}={1}", x.Key, x.Value ) ).Join( "&" );
//        }

//        /// <summary>
//        /// genera la cabcea de la petición con la autorización
//        /// </summary>
//        /// <param name="parameters"></param>
//        /// <param name="signature"></param>
//        /// <returns></returns>
//        private string GenerateAuthorizationHeaderValue( IEnumerable<KeyValuePair<string, string>> parameters, string signature ) {
//            return new StringBuilder( "OAuth " )
//                .Append( parameters.Concat( new KeyValuePair<string, string>( "oauth_signature", signature ) )
//                            .Where( x => x.Key.StartsWith( "oauth_" ) )
//                            .Select( x => string.Format( "{0}=\"{1}\"", x.Key, x.Value.EncodeRFC3986( ) ) )
//                            .Join( "," ) )
//                .ToString( );
//        }

//        /// <summary>
//        /// Crea la firma
//        /// </summary>
//        /// <param name="parameters"></param>
//        /// <returns></returns>
//        private string GenerateSignature( IEnumerable<KeyValuePair<string, string>> parameters ) {
//            var dataToSign = new StringBuilder( )
//                .Append( method ).Append( "&" )
//                .Append( url.EncodeRFC3986( ) ).Append( "&" )
//                .Append( parameters
//                            .OrderBy( x => x.Key )
//                            .Select( x => string.Format( "{0}={1}", x.Key, x.Value ) )
//                            .Join( "&" )
//                            .EncodeRFC3986( ) );

//            var signatureKey = string.Format( "{0}&{1}", oauth.ConsumerSecret.EncodeRFC3986( ), oauth.AccessSecret.EncodeRFC3986( ) );
//            var sha1 = new HMACSHA1( Encoding.ASCII.GetBytes( signatureKey ) );

//            // Codificaicón
//            var signatureBytes = sha1.ComputeHash( Encoding.ASCII.GetBytes( dataToSign.ToString( ) ) );

//            // Todo en Base64
//            return Convert.ToBase64String( signatureBytes );
//        }

//        /// <summary>
//        /// Parámetros para la autenticación. Lo obliga OAuth
//        /// </summary>
//        /// <param name="parameters"></param>
//        /// <param name="timestamp"></param>
//        /// <param name="nonce"></param>
//        private void AddOAuthParameters( IDictionary<string, string> parameters, string timestamp, string nonce ) {
//            parameters.Add( "oauth_version", VERSION );
//            parameters.Add( "oauth_consumer_key", oauth.ConsumerKey );
//            parameters.Add( "oauth_nonce", nonce );
//            parameters.Add( "oauth_signature_method", SIGNATURE_METHOD );
//            parameters.Add( "oauth_timestamp", timestamp );
//            parameters.Add( "oauth_token", oauth.AccessToken );
//        }

//        /// <summary>
//        /// Fecta timestamp
//        /// </summary>
//        /// <returns></returns>
//        private string GetTimestamp( ) {
//            return ( (int) ( DateTime.UtcNow - new DateTime( 1970, 1, 1 ) ).TotalSeconds ).ToString( );
//        }

//        /// <summary>
//        /// Crear un toquen unico (Hexa 8 digitos)
//        /// </summary>
//        /// <returns></returns>
//        private string CreateToken( ) {
//            return new Random( ).Next( 0x0000000, 0x7fffffff ).ToString( "X8" ); // Hexa 8 digitos
//        }

//    }


//    public static class TinyTwitterHelperExtensions {

//        public static string Join( this IEnumerable<string> items, string separator ) {
//            return string.Join( separator, items.ToArray( ) );
//        }

//        public static IEnumerable<T> Concat<T>( this IEnumerable<T> items, T value ) {
//            return items.Concat( new[ ] { value } );
//        }

//        /// <summary>
//        /// Codificaciíón RFC-3986
//        /// </summary>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public static string EncodeRFC3986( this string value ) {
//            if( string.IsNullOrEmpty( value ) ) {
//                return string.Empty;
//            }

//            var encoded = Uri.EscapeDataString( value );

//            return Regex
//                .Replace( encoded, "(%[0-9a-f][0-9a-f])", c => c.Value.ToUpper( ) )
//                .Replace( "(", "%28" )
//                .Replace( ")", "%29" )
//                .Replace( "$", "%24" )
//                .Replace( "!", "%21" )
//                .Replace( "*", "%2A" )
//                .Replace( "'", "%27" )
//                .Replace( "%7E", "~" );
//        }
//    }
//}
