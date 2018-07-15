//// ----------------------------------------------------------------------------
//// Título:    Read - Sample
////
//// Fecha:     01/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//string file = "Sammple.xml";
//XDocument myxml = XDocument.Load( file );
//// armamos la lista con Linq
//List<ClienteXML> listaXDoc = ( from xml in myxml.Descendants( "Cliente" )
//                               select new ClienteXML {
//                                Nombre = ( string ) xml.Element( "Nombre" ),
//                                Apellido = ( string ) xml.Element( "Apellido" ),
//                                Edad = ( int ) xml.Element( "Edad" ),
//                                Inventario = xml.Element( "Inventario" ).Elements( "Item" ).Select( a => a.Value ).ToList( )
//                               } ).ToList<ClienteXML>( );
