//// ----------------------------------------------------------------------------
//// Título:    Serialize
////
//// Fecha:     13/06/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//List<Tweet> lstTweets = new List<Tweet>( );
//            using( var stream = response.GetResponseStream( ) ) {

//                using( var reader = new StreamReader( stream ) ) {
//                    while( !reader.EndOfStream ) {
//                        string line = reader.ReadLine( );

//                        JArray  lstTwits = ( JArray ) JsonConvert.DeserializeObject( line );
//                        var serializer = new JsonSerializer( );
//                        foreach( var oneTwit in lstTwits ) {

//                            Tweet  oneTweet= new Tweet( );
//                            TW t = serializer.Deserialize<TW>( oneTwit.CreateReader( ) );

//                            if( null != t ) {
//                                oneTweet.Id = long.Parse( t.id );
//                                oneTweet.CreatedAt = DateTime.ParseExact( t.created_at, "ddd MMM dd HH:mm:ss zz00 yyyy", CultureInfo.InvariantCulture ).ToLocalTime( );
//                                oneTweet.UserName = t.user.name;
//                                oneTweet.ScreenName = t.user.screen_name;
//                                oneTweet.Text = t.Text;
//                                lstTweets.Add( oneTweet );

//                                if( null != t.entities && null != t.entities.media && t.entities.media.Count<TWMedia>() > 0 ){
//                                    TWMedia m = t.entities.media.ToList()[0];
//                                    oneTweet.MediaUrl = m.media_url;

//                                    if( null != m.sizes && m.type == "photo" && m.sizes.small != null ){
//                                        if( !string.IsNullOrEmpty( m.sizes.small.h )){
//                                            oneTweet.MediaHeight = Convert.ToInt32( m.sizes.small.h );
//                                        }
//                                        if( !string.IsNullOrEmpty( m.sizes.small.w )){
//                                            oneTweet.MediaWidth = Convert.ToInt32( m.sizes.small.w );
//                                        }
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }

//public class TWSmall
//    {
//        [JsonProperty( "w" )]
//        public string w { get; set; }

//        [JsonProperty( "h" )]
//        public string h { get; set; }
//    }

//    public class TWSizes
//    {
//        [JsonProperty( "small" )]
//        public TWSmall small { get; set; }
//    }

//    public class TWMedia
//    {
//        [JsonProperty( "id" )]
//        public string id { get; set; }

//        [JsonProperty( "media_url" )]
//        public string media_url { get; set; }

//        [JsonProperty( "type" )]
//        public string type { get; set; }

//        [JsonProperty( "sizes" )]
//        public TWSizes sizes { get; set; }
//    }


//    public class TWEntities
//    {
//        [JsonProperty( "media" )]
//        public IEnumerable<TWMedia> media{ get; set; }
//    }

//    public class TWUser
//    {
//        [JsonProperty( "name" )]
//        public string name{ get; set; }

//        [JsonProperty( "screen_name" )]
//        public string screen_name { get; set; }
//    }

//    public class TW
//    {
//        [JsonProperty( "created_at" )]
//        public string created_at { get; set; }

//        [JsonProperty( "id" )]
//        public string id { get; set; }

//        [JsonProperty( "Text" )]
//        public string Text { get; set; }

//        [JsonProperty( "user" )]
//        public TWUser user { get; set; }

//        [JsonProperty( "entities" )]
//        public TWEntities entities{ get; set; }

//    }

