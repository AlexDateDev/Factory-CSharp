//// ----------------------------------------------------------------------------
//// Título:    Serializar objetos
////
//// Fecha:    07/05/2015
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//using System.Xml.Serialization;


//XmlSerializer serializador = new XmlSerializer( typeof( eBrokerServiceSiniestro.siniestro ) );
//StringWriter escritor = new StringWriter( );
//serializador.Serialize( escritor, nuevoSiniestro);

//Console.WriteLine( escritor.ToString( ) );



//XmlSerializer serializador = new XmlSerializer( typeof( eBrokerServiceSiniestro.insertar ) );
//StringWriter escritor = new StringWriter( );
//XmlSerializerNamespaces sc = new XmlSerializerNamespaces( );
//sc.Add( "soapenv", "http://schemas.xmlsoap.org/soap/envelope/" );
//sc.Add( "ser", "http://service.server.ws.cfx.satec.es/" );

//serializador.Serialize( escritor, insertarNuevoSiniestro, sc );
//Console.WriteLine( escritor.ToString( ) );


//{<?xml version="1.0" encoding="utf-16"?>
//<insertar xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:ser="http://service.server.ws.cfx.satec.es/">
//  <arg0>
//    <numeroPolizaCompania>3000500054565</numeroPolizaCompania>
//    <tramite>O</tramite>
//    <culpa>S</culpa>
//    <estado>A</estado>
//  </arg0>
//  <arg2>60c6d277a8bd81de7fdde19201bf9c58a3df08f4</arg2>
//</insertar>}
