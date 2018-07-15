//// ----------------------------------------------------------------------------
//// Título:    ConfigurationSection
////
//// Fecha:     01/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//<configSections>
//    <section name="CustomApplicationConfig" type="Asurbrok.Application.CustomApplicationConfigSection, Asurbrok.Application" />
//</configSections>

//<CustomApplicationConfig>
//    <Credentials Username="itsme" Password="mypassword"/>
//    <PrimaryAgent Address="10.5.64.26" Port="3560"/>
//    <SecondaryAgent Address="10.5.64.7" Port="3570"/>
//    <Lanes>
//        <Lane Id="1" PointId="north" Direction="Entry"/>
//        <Lane Id="2" PointId="south" Direction="Exit"/>
//    </Lanes>
//</CustomApplicationConfig>


////
//// CustomApplicationConfigSection
////
//public class CustomApplicationConfigSection : System.Configuration.ConfigurationSection
//{
//    public const string SECTION_NAME = "CustomApplicationConfig";

//    [ConfigurationProperty( "Credentials" )]
//    public CredentialsConfigElement Credentials
//    {
//        get
//        {
//            return base[ "Credentials" ] as CredentialsConfigElement;
//        }
//    }

//    [ConfigurationProperty( "PrimaryAgent" )]
//    public ServerInfoConfigElement PrimaryAgent
//    {
//        get
//        {
//            return base[ "PrimaryAgent" ] as ServerInfoConfigElement;
//        }
//    }

//    [ConfigurationProperty( "SecondaryAgent" )]
//    public ServerInfoConfigElement SecondaryAgent
//    {
//        get
//        {
//            return base[ "SecondaryAgent" ] as ServerInfoConfigElement;
//        }
//    }


//    [ConfigurationProperty( "Lanes" )]
//    public LaneConfigCollection Lanes
//    {
//        get { return base[ "Lanes" ] as LaneConfigCollection; }
//    }
//}

////
////
////

//[ConfigurationCollection( typeof( LaneConfigElement ), AddItemName = "Lane", CollectionType = ConfigurationElementCollectionType.BasicMap )]
//public class LaneConfigCollection : ConfigurationElementCollection
//{
//    public LaneConfigElement this[ int index ]
//    {
//        get { return ( LaneConfigElement ) BaseGet( index ); }
//        set
//        {
//            if( BaseGet( index ) != null ) {
//                BaseRemoveAt( index );
//            }
//            BaseAdd( index, value );
//        }
//    }

//    public void Add( LaneConfigElement serviceConfig )
//    {
//        BaseAdd( serviceConfig );
//    }

//    public void Clear( )
//    {
//        BaseClear( );
//    }

//    protected override ConfigurationElement CreateNewElement( )
//    {
//        return new LaneConfigElement( );
//    }

//    protected override object GetElementKey( ConfigurationElement element )
//    {
//        return ( ( LaneConfigElement ) element ).Id;
//    }

//    public void Remove( LaneConfigElement serviceConfig )
//    {
//        BaseRemove( serviceConfig.Id );
//    }

//    public void RemoveAt( int index )
//    {
//        BaseRemoveAt( index );
//    }

//    public void Remove( String name )
//    {
//        BaseRemove( name );
//    }

//}

////
////
////
//public class LaneConfigElement : ConfigurationElement
//{
//    [ConfigurationProperty( "Id" )]
//    public string Id
//    {
//        get
//        {
//            return base[ "Id" ] as string;
//        }
//    }

//    [ConfigurationProperty( "PointId" )]
//    public string PointId
//    {
//        get
//        {
//            return base[ "PointId" ] as string;
//        }
//    }

//    [ConfigurationProperty( "Direction" )]
//    public Direction? Direction
//    {
//        get
//        {
//            return base[ "Direction" ] as Direction?;
//        }
//    }
//}

////
////
////
//public enum Direction
//{
//    Entry,
//    Exit
//}

////
////
////
//public class ServerInfoConfigElement : ConfigurationElement
//{
//    [ConfigurationProperty( "Address" )]
//    public string Address
//    {
//        get
//        {
//            return base[ "Address" ] as string;
//        }
//    }

//    [ConfigurationProperty( "Port" )]
//    public int? Port
//    {
//        get
//        {
//            return base[ "Port" ] as int?;
//        }
//    }
//}

////
////
////

//public class CredentialsConfigElement : System.Configuration.ConfigurationElement
//{
//    [ConfigurationProperty( "Username" )]
//    public string Username
//    {
//        get
//        {
//            return base[ "Username" ] as string;
//        }
//    }

//    [ConfigurationProperty( "Password" )]
//    public string Password
//    {
//        get
//        {
//            return base[ "Password" ] as string;
//        }
//    }
//}
