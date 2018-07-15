//// ----------------------------------------------------------------------------
//// Título:    Deserialize
////
//// Fecha:     13/06/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//using( var stream = response.GetResponseStream( ) ) {
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

