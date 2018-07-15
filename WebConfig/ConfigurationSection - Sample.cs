//// ----------------------------------------------------------------------------
//// T�tulo:    ConfigurationSection - Sample
////
//// Fecha:     01/07/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------


//public ActionResult Index()
//{
//    DashboardSection DashboardConfig = ConfigurationManager.GetSection( DashboardSection.SECTION_NAME ) as DashboardSection;

//    return View( );
//}

//// ------------------------------------------------------------

//<?xml version="1.0" encoding="utf-8"?>
//<configuration>

//    <configSections>
//        <section name="Dashboard" type="Asurbrok.Application.DashboardSection, Asurbrok.Application" />
//    </configSections>

//    <Dashboard>
//        <Stats>
//            <Stat TextTitle="Vehicles"    TextFooter = "7 pòlisses" Color = "blue-madison" Icon = "fa-car" Link = "/Empresa/Producto/1" />
//            <Stat TextTitle = "Pyme" TextFooter = "14 pòlisses" Color = "blue-steel" Icon = "fa-gear" Link = "/Empresa/Producto/2" />
//            <Stat TextTitle = "Comerç" TextFooter = "3 pòlisses" Color = "blue-hoki" Icon = "fa-shopping-cart" Link = "/Empresa/Producto/3" />
//        </Stats>
//    </Dashboard>

//</configuration>

//// ----------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Linq;
//using System.Web;

//namespace Asurbrok.Application
//{

//    /// <summary>
//    /// Section del WebConfig
//    /// </summary>
//    public class DashboardSection : System.Configuration.ConfigurationSection
//    {
//        public const string SECTION_NAME = "Dashboard";

//        [ConfigurationProperty( "Stats" )]
//        public StatElementCollection Stats
//        {
//            get { return base[ "Stats" ] as StatElementCollection; }
//        }
//    }

//    /// <summary>
//    /// Coleccion de Stats
//    /// </summary>
//    [ConfigurationCollection( typeof( StatElement ), AddItemName = "Stat", CollectionType = ConfigurationElementCollectionType.BasicMap )]
//    public class StatElementCollection : ConfigurationElementCollection
//    {
//        public StatElement this[ int index ]
//        {
//            get { return ( StatElement ) BaseGet( index ); }
//            set
//            {
//                if( BaseGet( index ) != null ) {
//                    BaseRemoveAt( index );
//                }
//                BaseAdd( index, value );
//            }
//        }

//        public void Add( StatElement serviceConfig )
//        {
//            BaseAdd( serviceConfig );
//        }

//        public void Clear( )
//        {
//            BaseClear( );
//        }

//        protected override ConfigurationElement CreateNewElement( )
//        {
//            return new StatElement( );
//        }

//        protected override object GetElementKey( ConfigurationElement element )
//        {
//            return ( ( StatElement ) element ).TextTitle;
//        }

//        public void Remove( StatElement serviceConfig )
//        {
//            BaseRemove( serviceConfig.TextTitle );
//        }

//        public void RemoveAt( int index )
//        {
//            BaseRemoveAt( index );
//        }

//        public void Remove( String name )
//        {
//            BaseRemove( name );
//        }

//    }


//    /// <summary>
//    /// Un Elemento Stat de la coleccion de Stats del Dashboard
//    /// </summary>
//    public class StatElement : ConfigurationElement
//    {
//        [ConfigurationProperty( "TextTitle", IsKey = true, IsRequired = true )]
//        public string TextTitle
//        {
//            get { return ( string ) this[ "TextTitle" ]; }
//            set { this[ "TextTitle" ] = value; }
//        }

//        [ConfigurationProperty( "TextFooter", IsKey = false, IsRequired = true )]
//        public string TextFooter
//        {
//            get { return ( string ) this[ "TextFooter" ]; }
//            set { this[ "TextFooter" ] = value; }
//        }

//        [ConfigurationProperty( "Color", IsKey = false, IsRequired = true )]
//        public string Color
//        {
//            get { return ( string ) this[ "Color" ]; }
//            set { this[ "Color" ] = value; }
//        }

//        [ConfigurationProperty( "Icon", IsKey = false, IsRequired = true )]
//        public string Icon
//        {
//            get { return ( string ) this[ "Icon" ]; }
//            set { this[ "Icon" ] = value; }
//        }
//        [ConfigurationProperty( "Link", IsKey = false, IsRequired = true )]
//        public string Link
//        {
//            get { return ( string ) this[ "Link" ]; }
//            set { this[ "Link" ] = value; }
//        }
//    }
//}
