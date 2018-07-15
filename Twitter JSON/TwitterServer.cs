//// ----------------------------------------------------------------------------
//// T�tulo:    TwitterServer
////
//// Fecha:     27/03/2013
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Net;
//using System.Security.Cryptography;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Xml;
//using System.Xml.Linq;

//namespace Atexsa.Factory.Twitter {

//    ///
//    /// V 1.0.0 27/03/2013
//    /// Se ha añadido el poder obtener los retwits del usuario
//    ///
//    /// <summary>
//    /// Servicor Tweeter que se comunica con Tweeter
//    /// </summary>
//    public class TwitterServer {

//        /// <summary>
//        /// Autenticación para acceder a la cuanta de Tweeter
//        /// </summary>
//        private readonly OAuthenticationInfo oauth;

//        /// <summary>
//        /// Url utilizada para enviar mensajes mediante un POST
//        /// </summary>
//        private const string UrlSendMessage = "http://api.twitter.com/1/statuses/update.xml";

//        /// <summary>
//        /// Url de donde leer todos los mensajes de la cuenta Tweeter.
//        /// Lee todas las Timelines
//        /// </summary>
//        private const string UrlGetAllMessages = "http://api.twitter.com/1/statuses/home_timeline.xml"; // Los parametros se añaden en el Builder

//        /// <summary>
//        /// Url de donde obtener sólo las respuestas
//        /// </summary>
//        private const string UrlGetAllMentions = "http://api.twitter.com/1/statuses/mentions.xml";

//        /// <summary>
//        /// Url de donde obtener sólo los twits propios del usuario
//        /// </summary>
//        private const string UrlGetUserTwits = "http://api.twitter.com/1/statuses/user_timeline.xml";

//        /// <summary>
//        /// Url de donde obtener sólo los Re-twits propios del usuario
//        /// </summary>
//        private const string UrlGetUserRetwits = "http://api.twitter.com/1/statuses/retweeted_by_me.xml";

//        /// <summary>
//        /// Número mágimo de mensajes a leer
//        /// </summary>
//        private const int _MaxMessageToRead = 10;

//        /// <summary>
//        /// Constructor
//        /// </summary>
//        /// <param name="oauth"></param>
//        public TwitterServer( OAuthenticationInfo oauth ) {
//            this.oauth = oauth;
//        }

//        /// <summary>
//        /// Envia un mensage por medio de Post
//        /// </summary>
//        /// <param name="message"></param>
//        public void SendMessage( string message ) {

//            // Creamos una nueva petición
//            RequestBuilder req = new RequestBuilder( oauth, "POST", UrlSendMessage );
//            req.AddParameter( "status", message );
//            req.Execute( );
//        }

//        /// <summary>
//        /// Lee todos los mensajes de la cuenta
//        /// </summary>
//        /// <param name="sinceId"></param>
//        /// <param name="count"></param>
//        /// <returns></returns>
//        public IEnumerable<Tweet> GetHomeTimeline( long? sinceId, int? count ) {
//            return GetTimeline( UrlGetAllMessages, sinceId, count );
//        }

//        /// <summary>
//        /// Lee sólo los twits que son respuestas
//        /// </summary>
//        /// <param name="sinceId"></param>
//        /// <param name="count"></param>
//        /// <returns></returns>
//        public IEnumerable<Tweet> GetMentions( long? sinceId, int? count ) {
//            return GetTimeline( UrlGetAllMentions, sinceId, count );
//        }

//        /// <summary>
//        /// Lee los twites propies del usuario
//        /// </summary>
//        /// <param name="sinceId"></param>
//        /// <param name="count"></param>
//        /// <returns></returns>
//        public IEnumerable<Tweet> GetUserTimeline( long? sinceId, int? count  ) {
//            return GetTimeline( UrlGetUserTwits, sinceId, count );
//        }

//        /// <summary>
//        /// Leeo los twits i/o re-twits del usuario
//        /// </summary>
//        /// <param name="sinceId"></param>
//        /// <param name="count"></param>
//        /// <param name="IncludeRetwits"></param>
//        /// <returns></returns>
//        public IEnumerable<Tweet> GetUserTimeline( long? sinceId, int? count, bool IncludeRetwits ) {
//            List<Tweet> IETwits = GetTimeline( UrlGetUserTwits, sinceId, count ).ToList( );


//            if( IncludeRetwits ) {
//                List<Tweet> IEReTwits = GetTimeline( UrlGetUserRetwits, sinceId, count ).ToList( );
//                IETwits.AddRange( IEReTwits );
//                IETwits = IETwits.OrderByDescending( p => p.CreatedAt ).ToList( );
//            }
//            return IETwits;

//        }


//        /// <summary>
//        /// Consulta tweets. modo GET.
//        /// Devuelve formato XML ya que en NET se integra mejor
//        /// </summary>
//        /// <param name="url"></param>
//        /// <param name="sinceId"></param>
//        /// <param name="count"></param>
//        /// <returns></returns>
//        private IEnumerable<Tweet> GetTimeline( string url, long? sinceId, int? count ) {

//            var builder = new RequestBuilder( oauth, "GET", url );

//            if( sinceId.HasValue ) {
//                builder.AddParameter( "since_id", sinceId.Value.ToString( ) );
//            }

//            if( count.HasValue ) {
//                builder.AddParameter( "count", count.Value.ToString( ) );
//            }
//            else {
//                count = _MaxMessageToRead;
//            }

//            builder.AddParameter( "include_entities", "true" );
//            var response = builder.Execute( );

//            using( var stream = response.GetResponseStream( ) ) {
//                // Transformamos el elemento XML en entidades
//                var xml = XDocument.Load( new XmlTextReader( stream ) );

//                IEnumerable<XElement> lstElements = xml.Descendants( "status" );

//                List<Tweet> lstTweets = new List<Tweet>( );

//                foreach( XElement oneElement in lstElements ) {
//                    Tweet  oneTweet= new Tweet( );

//                    oneTweet.Id         = long.Parse( oneElement.Element( "id" ).Value );
//                    oneTweet.CreatedAt    = DateTime.ParseExact( oneElement.Element( "created_at" ).Value, "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture ).ToLocalTime( );
//                    oneTweet.UserName    = oneElement.Element( "user" ).Element( "name" ).Value;
//                    oneTweet.ScreenName    = oneElement.Element( "user" ).Element( "screen_name" ).Value;
//                    oneTweet.Text        = oneElement.Element( "text" ).Value;

//                    XElement oneElementEntity = oneElement.Element( "entities" );

//                    if( null != oneElementEntity ) {
//                        // Media
//                        XElement oneElementMedia = oneElementEntity.Element( "media" );

//                        if(null != oneElementMedia ){
//                            // Creative
//                            XElement oneElementMediaCreative =     oneElementMedia.Element( "creative" );

//                            if( null != oneElementMediaCreative ) {

//                                // Hay un media del tipo "photo"
//                                if( oneElementMediaCreative.Element( "type" ).Value == "photo" ) {

//                                    // Url de la foto
//                                    oneTweet.MediaUrl = oneElementMediaCreative.Element( "media_url" ).Value;

//                                    // Tamaños
//                                    XElement oneElementMediaCreativeSizes = oneElementMediaCreative.Element( "sizes" );

//                                    if( null != oneElementMediaCreativeSizes ) {

//                                        // Small
//                                        XElement oneElementMediaCreativeSizesSmall = oneElementMediaCreativeSizes.Element( "small" );

//                                        if( null != oneElementMediaCreativeSizesSmall ) {
//                                            oneTweet.MediaWidth = Convert.ToInt32( oneElementMediaCreativeSizesSmall.Element( "w" ).Value );
//                                            oneTweet.MediaHeight = Convert.ToInt32( oneElementMediaCreativeSizesSmall.Element( "h" ).Value );
//                                        }
//                                    }
//                                }
//                            }
//                        }
//                    }

//                    lstTweets.Add( oneTweet );
//                }
//                return lstTweets;

//                //return xml.Descendants( "status" )
//                //    .Select( x => new Tweet {
//                //        Id            = long.Parse( x.Element( "id" ).Value ),
//                //        CreatedAt = DateTime.ParseExact( x.Element( "created_at" ).Value, "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture ).ToLocalTime( ),
//                //        UserName    = x.Element( "user" ).Element( "name" ).Value,
//                //        ScreenName    = x.Element( "user" ).Element( "screen_name" ).Value,
//                //        Text        = x.Element( "text" ).Value
//                //    } )
//                //    .ToArray( );
//            }
//        }

//        /*
//         * +        base
//<status>
//    <created_at>Thu Mar 21 09:02:25 +0000 2013</created_at>
//    <id>314663276724244480</id>
//    <text>Funciona perfecte (sense imatge)</text>
//    <source>web</source>
//    <truncated>false</truncated>
//    <in_reply_to_status_id></in_reply_to_status_id>
//    <in_reply_to_user_id></in_reply_to_user_id>
//    <in_reply_to_screen_name></in_reply_to_screen_name>
//    <user>
//      <id>1227205110</id>
//      <name>Alex Atexsa</name>
//      <screen_name>alexatexsa</screen_name>
//      <location></location>
//      <profile_image_url>http://a0.twimg.com/sticky/default_profile_images/default_profile_5_normal.png</profile_image_url>
//      <profile_image_url_https>https://si0.twimg.com/sticky/default_profile_images/default_profile_5_normal.png</profile_image_url_https>
//      <url></url>
//      <description></description>
//      <protected>false</protected>
//      <followers_count>0</followers_count>
//      <profile_background_color>C0DEED</profile_background_color>
//      <profile_text_color>333333</profile_text_color>
//      <profile_link_color>0084B4</profile_link_color>
//      <profile_sidebar_fill_color>DDEEF6</profile_sidebar_fill_color>
//      <profile_sidebar_border_color>C0DEED</profile_sidebar_border_color>
//      <friends_count>1</friends_count>
//      <created_at>Thu Feb 28 10:22:16 +0000 2013</created_at>
//      <favourites_count>0</favourites_count>
//      <utc_offset>3600</utc_offset>
//      <time_zone>Madrid</time_zone>
//      <profile_background_image_url>http://a0.twimg.com/images/themes/theme1/bg.png</profile_background_image_url>
//      <profile_background_image_url_https>https://si0.twimg.com/images/themes/theme1/bg.png</profile_background_image_url_https>
//      <profile_background_tile>false</profile_background_tile>
//      <profile_use_background_image>true</profile_use_background_image>
//      <geo_enabled>false</geo_enabled>
//      <verified>false</verified>
//      <statuses_count>15</statuses_count>
//      <lang>es</lang>
//      <contributors_enabled>false</contributors_enabled>
//      <is_translator>false</is_translator>
//      <listed_count>0</listed_count>
//      <default_profile>true</default_profile>
//      <default_profile_image>true</default_profile_image>
//      <following>true</following>
//      <follow_request_sent></follow_request_sent>
//      <notifications></notifications>
//    </user>
//    <geo />
//    <coordinates />
//    <place />
//    <contributors />
//    <retweet_count>0</retweet_count>
//    <favorite_count>0</favorite_count>
//    <favorited>false</favorited>
//    <retweeted>false</retweeted>
//  </status>

//         * */
//        /**
//         * private IEnumerable<Tweet> GetTimeline( string url, long? sinceId, int? count ) {

//            var builder = new RequestBuilder( oauth, "GET", url );

//            if( sinceId.HasValue ) {
//                builder.AddParameter( "since_id", sinceId.Value.ToString( ) );
//            }

//            if( count.HasValue ) {
//                builder.AddParameter( "count", count.Value.ToString( ) );
//            }
//            else {
//                count = _MaxMessageToRead;
//            }

//            //builder.AddParameter( "include_entities", "true" );
//            var response = builder.Execute( );

//            using( var stream = response.GetResponseStream( ) ) {
//                // Transformamos el elemento XML en entidades
//                var xml = XDocument.Load( new XmlTextReader( stream ) );
//                return xml.Descendants( "status" )
//                    .Select( x => new Tweet {
//                        Id            = long.Parse( x.Element( "id" ).Value ),
//                        CreatedAt = DateTime.ParseExact( x.Element( "created_at" ).Value, "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture ).ToLocalTime( ),
//                        UserName    = x.Element( "user" ).Element( "name" ).Value,
//                        ScreenName    = x.Element( "user" ).Element( "screen_name" ).Value,
//                        Text        = x.Element( "text" ).Value
//                    } )
//                    .ToArray( );
//            }
//        }
//         * */
//    }

//}
